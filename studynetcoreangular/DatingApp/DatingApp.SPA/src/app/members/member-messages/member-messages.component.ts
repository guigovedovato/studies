import { Component, OnInit } from '@angular/core';
import { Input } from '@angular/core';
import { Message } from '../../_models/message';
import { AuthService } from '../../_services/auth.service';
import { UserService } from '../../_services/user.service';
import { AlertifyService } from '../../_services/alertify.service';
import * as _ from 'underscore';

@Component({
  selector: 'app-member-messages',
  templateUrl: './member-messages.component.html',
  styleUrls: ['./member-messages.component.css']
})
export class MemberMessagesComponent implements OnInit {
  @Input() userId: number;
  messages: Message[];
  newMessage: any = {};

  constructor(private authService: AuthService,
    private userService: UserService,
   private alertify: AlertifyService) { }

  ngOnInit() {
    this.loadMessages();
  }

  loadMessages() {
    const currentUserId = +this.authService.decodedToken.nameid;
    this.userService.getMessageThread(currentUserId, this.userId)
      .do(messages => {
        _.each(messages, (message: Message) => {
          if (message.isRead === false && message.recipientId === currentUserId) {
            this.userService.markAsRead(message.id, currentUserId);
          }
        });
      })
      .subscribe(messages => {
        this.messages = messages;
      }, error => {
        this.alertify.error(error);
      });
  }

  sendMessage() {
    this.newMessage.recipientId = this.userId;
    this.userService.sendMessage(this.authService.decodedToken.nameid, this.newMessage).subscribe(message => {
      this.messages.unshift(message);
      this.newMessage.content = '';
    }, error => {
      this.alertify.error(error);
    });
  }

}
