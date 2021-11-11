def binary_search(arr,ele):
    first = 0
    last = len(arr)-1
    found = False
    while first <= last and not found:
        mid = (first+last)//2
        if arr[mid] == ele:
            found = True
        else:
            if ele < arr[mid]:
                last = mid - 1
            else:
                first = mid + 1
    return found


arr = [1,2,3,4,5,6,7,8,9]
print(binary_search(arr,6))
print(binary_search(arr,12))

def rec_bin_search(arr,ele):
    if len(arr) == 0:
        return False
    else:
        mid = len(arr)//2
        if arr[mid] == ele:
            return True
        else:
            if ele < arr[mid]:
                return rec_bin_search(arr[:mid],ele)
            else:
                return rec_bin_search(arr[mid+1:],ele)


arr = [1,2,3,4,5,6,7,8,9]
print(rec_bin_search(arr,6))
print(rec_bin_search(arr,12))
