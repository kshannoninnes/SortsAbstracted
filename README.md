# Sorts: Abstracted
This project is a C# implementation of the sorting design patterns discussed by [Dung (Zung) Nguyen](https://csweb.rice.edu/zung-nguyen) and [Stephen B. Wong](https://csweb.rice.edu/stephen-wong) in their paper ["Design Patterns for Sorting"](https://www.cs.rice.edu/~javaplt/papers/sigcse2001.pdf).

### Background
Based on a paper written by [S. M. Merritt](https://digitalcommons.pace.edu/pace-women/34/) and [K. K. Lau](https://www.research.manchester.ac.uk/portal/kung-kiu.lau.html) titled ["A Logical Inverted Taxonomy of Sorting Algorithms"](https://pdfs.semanticscholar.org/5976/5d78a2ed9877db8681069de746df99671cab.pdf), Nguyen and Wong explore the idea of abstracting comparison-based sorting using several design patterns. Most notably, the template design pattern is used to perform the sorting by way of recursively dividing an array into subsections and later merging (or "conquering") the subsections back into a single array. Not only is this used for the traditional Divide and Conquer sorting algorithms such as MergeSort and QuickSort, but also sorting algorithms that aren't traditionally associated with D&C such as SelectionSort and InsertionSort.

Nguyen and Wong also make use of the strategy pattern, to decouple the concept of ordering from the sorting, as well as the decorator pattern to allow for extending the sorts for such purposes as animating or running performance analysis on the sorting algorithms.

### Design Patterns
##### Template
The core of the idea is the template design pattern. By abstracting away the definitions of Split and Join, we're able to simulate an iterative-based sort by simply returning high or low from the split method, depending on whether you're iterating from low-high, or high-low.

##### Strategy
As part of good practices for reducing coupling, we also make use of the strategy pattern to decouple the strategy of ordering from sorting. Doing this allows a user to simply define how two objects are determined to be "Equal" and "LessThan" in a custom Order class, which allows any Sort class to sort any kind of arbitrary object.

### Todo
- ~~Implement more commonly used sorts such as Mergesort, Heapsort, etc~~
- ~~Implement GUI Visualizer for users to see the sorts in action~~ See [VisualSorts](https://github.com/kshannoninnes/VisualSorts)
- Implement less commonly used sorts such as ShellSort and TimSort

### License
This project is licensed under the MIT License - see the LICENSE.md file for details