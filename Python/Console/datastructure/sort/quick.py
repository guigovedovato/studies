def quick_sort(arr):
    quick_sort_help(arr,0,len(arr)-1)


def quick_sort_help(arr,first,last):
    if first < last:
        split = partition(arr,first,last)
        quick_sort_help(arr,first,split-1)
        quick_sort_help(arr,split+1,last)


def partition(arr,first,last):
    pivot = arr[first]
    left = first+1
    right = last
    
    done = False
    
    while not done:
        while left <= right and arr[left] <= pivot:
            left += 1
        while arr[right] >= pivot and right >= left:
            right -= 1
        if right < left:
            done = True
        else:
            tmp = arr[left]
            arr[left] = arr[right]
            arr[right] = tmp
    tmp = arr[first]
    arr[first] = arr[right]
    arr[right] = tmp
    
    return right


arr = [2,5,4,6,7,3,1,12,15,11]
print(arr)
quick_sort(arr)
print(arr)
