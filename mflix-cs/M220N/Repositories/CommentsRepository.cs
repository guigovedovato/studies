using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using M220N.Models;
using M220N.Models.Projections;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace M220N.Repositories
{
    public class CommentsRepository
    {
        private readonly IMongoCollection<Comment> _commentsCollection;
        private readonly MoviesRepository _moviesRepository;

        public CommentsRepository(IMongoClient mongoClient)
        {
            var camelCaseConvention = new ConventionPack { new CamelCaseElementNameConvention() };
            ConventionRegistry.Register("CamelCase", camelCaseConvention, type => true);

            _commentsCollection = mongoClient.GetDatabase("sample_mflix").GetCollection<Comment>("comments");
            _moviesRepository = new MoviesRepository(mongoClient);
        }

        /// <summary>
        /// Adds a comment.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="movieId"></param>
        /// <param name="comment"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>The Movie associated with the comment.</returns>
        public async Task<Movie> AddCommentAsync(User user, ObjectId movieId, string comment,
            CancellationToken cancellationToken = default)
        {
            try
            {
                var newComment = new Comment
                {
                    Date = DateTime.UtcNow,
                    Text = comment,
                    Name = user.Name,
                    Email = user.Email,
                    MovieId = movieId
                };

                await _commentsCollection.InsertOneAsync(newComment, new InsertOneOptions(), cancellationToken);

                return await _moviesRepository.GetMovieAsync(movieId.ToString(), cancellationToken);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Deletes a comment. Only the comment owner can delete a comment.
        /// </summary>
        /// <param name="movieId"></param>
        /// <param name="commentId"></param>
        /// <param name="user"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>The movie associated with the comment that is being deleted.</returns>
        public async Task<Movie> DeleteCommentAsync(ObjectId movieId, ObjectId commentId,
            User user, CancellationToken cancellationToken = default)
        {
            _commentsCollection.DeleteOne(
                Builders<Comment>.Filter.Where(
                    c => c.MovieId == movieId
                         && c.Id == commentId
                         && c.Email == user.Email));

            return await _moviesRepository.GetMovieAsync(movieId.ToString(), cancellationToken);
        }

        public async Task<TopCommentsProjection> MostActiveCommentersAsync()
        {
            try
            {
                List<ReportProjection> result = await _commentsCollection
                   .WithReadConcern(ReadConcern.Majority)
                   .Aggregate()
                   .Group(new BsonDocument
                   {
                       {"_id", "$email"},
                       {"count", new BsonDocument("$sum", 1)}
                   })
                   .Sort(Builders<BsonDocument>.Sort.Descending("count"))
                   .Limit(20)
                   .Project<ReportProjection>(Builders<BsonDocument>.Projection.Include("email").Include("count"))
                   .ToListAsync();

                return new TopCommentsProjection(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing comment. Only the comment owner can update the comment.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="movieId"></param>
        /// <param name="commentId"></param>
        /// <param name="comment"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>An UpdateResult</returns>
        public async Task<UpdateResult> UpdateCommentAsync(User user,
            ObjectId movieId, ObjectId commentId, string comment,
            CancellationToken cancellationToken = default)
        {
            return await _commentsCollection.UpdateOneAsync(
             Builders<Comment>.Filter.Where(c => c.Id == commentId && c.Email == user.Email),
             Builders<Comment>.Update.Set(c => c.Text, comment).Set(c => c.Date, DateTime.UtcNow),
             new UpdateOptions { IsUpsert = false },
             cancellationToken);
        }
    }
}