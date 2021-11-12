def insertion_sort(arr):
    for i in range(1,len(arr)):
        current = arr[i]
        position = i
        while position > 0 and arr[position-1] > current:
            arr[position] = arr[position-1]
            position -= 1
        arr[position] = current


arr = [4,6,2,7,1,9,11,21,13,5]
print(arr)
insertion_sort(arr)
print(arr)
