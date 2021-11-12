def selection_sort(arr):
    for slot in range(len(arr)-1,0,-1):
        max = 0
        for location in range(1,slot+1):
            if arr[location] > arr[max]:
                max = location
        tmp = arr[slot]
        arr[slot] = arr[max]
        arr[max] = tmp


arr = [5,8,3,10,1]
print(arr)
selection_sort(arr)
print(arr)
