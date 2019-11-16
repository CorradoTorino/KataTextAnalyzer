Create a service that:

- accepts a human-readable typical piece of text 

- - e.g. chapter from a book, 
  - not just a string of characters, 
  - but actually, a couple of paragraphs of text with all kinds of (un)expected characters). 

The following operations must be supported by the service:

1. Sort( text, sort option )
2. GenerateStatistics( text )

- The first method must return the given text in the given sorted way, there should be three possible sorting options available. 
- The second method must return a complex data type that will tell the consumer how many hyphens, words and spaces are inside the given text. 
- The complex data type must be called TextStatistics.
