# Sorts: Abstracted
This project is a C# implementation of the sorting design patterns discussed by [Dung (Zung) Nguyen](https://csweb.rice.edu/zung-nguyen) and [Stephen B. Wong](https://csweb.rice.edu/stephen-wong) in their paper ["Design Patterns for Sorting"](https://www.cs.rice.edu/~javaplt/papers/sigcse2001.pdf).

### Background
Based on a paper written by [S. M. Merritt](https://digitalcommons.pace.edu/pace-women/34/) and [K. K. Lau](https://www.research.manchester.ac.uk/portal/kung-kiu.lau.html) titled ["A Logical Inverted Taxonomy of Sorting Algorithms"](https://pdfs.semanticscholar.org/5976/5d78a2ed9877db8681069de746df99671cab.pdf), Nguyen and Wong explore the idea of abstracting comparison-based sorting using several design patterns. Most notably, the template design pattern is used to perform the sorting by way of recursively dividing an array into subsections and later merging (or "conquering") the subsections back into a single array. Nguyen and Wong also make use of the strategy pattern, to decouple the concept of ordering from the sorting, as well as the decorator pattern to allow for extending the sorts for such purposes as animating or running performance analysis on the sorting algorithms.

### Todo
- Implement more commonly used sorts such as Mergesort, Heapsort, etc
- Implement GUI Visualizer for users to see the sorts in action

### License
This project is licensed under the MIT License - see the LICENSE.md file for details