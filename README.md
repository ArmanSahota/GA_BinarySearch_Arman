# GA_BinarySearch_Arman
### What is binary search and how does it work?
Binary search looks at an array by index. It splits the index down the middle and sees if the number on the index was bigger or smaller than the certain index we are looking for. If it is smaller it takes the bigger half out and splits it donw the middle again and again until it can land on right index and number.

### What is the time complexity of binary search?
The time complexity of binary search is O(log n), where 'n' is the number of elements in the sorted array. The algorithm's efficiency lies in its ability to eliminate half of the remaining elements in each step, resulting in a logarithmic time complexity.

### When is binary search preferred over linear search?
Binary search is preferred over linear search when the array is sorted.
### What are the key requirements for binary search to work correctly?
For binary search to work correctly, the array must be sorted in ascending or descending order. 
### Can binary search be applied to unsorted arrays? Why or why not?
No, binary search cannot be directly applied to unsorted arrays. This is because the algorithm's are using bigger and smaller numbers to find if it is bigger or smaller to figure out if the index we are looking for it in the middle or not.
If we don't know whats bigger or smaller going in the middle and eliminating half may eliminate index we are looking for since it is not in order.
