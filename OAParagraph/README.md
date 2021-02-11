Hello
I chose to solve this problem by implementing a regex approach.
Regex is made for solving this type of problem.

I chose a dictionary object as it is very fast in case we need to process larger text, not just paragraphs.
We may need a limit to the number of words or we would simply split out the text and run in parallel and stitch results back together.

I call this implementation a cheese pizza as I am using regex \w+ to get the words it handles a lot of the issues we may have like double spaces,
punctuation, tabs, line spaces etc right out of the box.

I did make an assumption that possessive words like mike's or plans' would be 'stored' as mike and plans, for example. This is to demonstrate
in the helper class we can do all kinds of preprocessing rules as the business requirements dictate. We could even put in the confg etc. a series of
regex replaces to run in a particular order. Clean number, dates, and more.

We can also go further and compare words to dictionaries such as websters and special medical dictionaries as well if needed. This will also help
with misspellings words not seperated with a space, hyphens and such.

Also, currently in this implementation we are not managing contractions, we would need a rule to map them from don't to do not for example.




enhancements down the road?
I would definitely sort the output!
multiple paragraph support?
supported languages?
translations?


Thank you.