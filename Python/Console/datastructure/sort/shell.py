def shell_sort(arr):
    sublist_count = len(arr)//2
    while sublist_count > 0:
        for start in range(sublist_count):
            gap_insertion_sort(arr,start,sublist_count)
        sublist_count = sublist_count//2


def gap_insertion_sort(arr,start,gap):
    for i in range(start+gap,len(arr),gap):
        current = arr[i]
        position = i
        while position >= gap and arr[position-gap] > current:
            arr[position] = arr[position-gap]
            position = position-gap
        arr[position] = current


arr = [45,67,23,58,21,24,7,2,6,4,90]
print(arr)
shell_sort(arr)
print(arr)
