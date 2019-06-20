Answers to exercise questions.

1)	See solution.

2)	  i) Parameterise the steps to accept variables (cinnamon, apples...).
	 ii) Write the Scenario as a Scenario Outline.
	iii) Write an example table with a row for each ingredient with the variable name as the column first row.

3)	See solution (note that the solution contains the changes for step 2).

4)  I am not completely at ease with this JavaScript as I don't have any experience of JavaScript with Gherkin but some general coding practices that could be applied to this code are
	  i) Improved formatting and indentation.
	 ii) Pull the literal texts out of the body and place them as constants (at the top of the file).
	iii) The paths to the elements being verified are very complex with a lot of duplication which is error prone. Although it is not usually possible to change these because they are dictated by the application, other techniques can be used to reduce the duplication, make changes easier or avoid these problems altogether. Breaking the paths down into parameterised segments and placing these as constants at the top of the file will help. One way to avoid this altogether would be to locate the elements by another means such as using the IDs rather than traversing the DOM. 
	 iv) The tests should be written in the first person (When I... not when the user...).

Additional notes.
I understand that this exercise was supposed to be completed in JavaScript although I have done it in C# using Selenium. I hope that that, although not ideal, does demonstrate my testing, coding and code organisational skills. You will see that my CV does not claim any experience in Gherkin and that JavaScript is not one of my key competencies. However, to convert to Gherkin and to write such tests in JavaScript would not be a problem given a small amount of time. I trust that this is acceptable.

This is a quick (and dirty) prototype so I've paid little attention to things like...
	  1) Parameterising the driver instance so that different drivers can be selected at run time (Chrome, IE, Firefox...).
	  2) No attempts have been made to keep the solution DRY. As more tabs and pages are added there is scope for a large amount of duplication. I am very mindful of over-engineering the tests (which can make them very inflexible and / or difficult to understand), there is a balance to be met so that the duplication is kept to a manageable level without making the tests too ridged.
	  3) Everything is hardcoded or in some cases not coded at all. For example, the website address is not specified in this prototype. This and many other data should be configured in a config file to allow these to be changed without re-compilation. This is particularly useful if the tests are to be run in more than one deployment group.
	  4) There is no structure to this solution. In a productionised solution there would be folders and sub-folders to group the tests into logical groups.
	  5) No tags (categories) have been specified so this is a 'run all or nothing' approach. As the number of tests increases it would be advantageous to create tags to identify groups of tests such as smoke tests, or functional areas (login, payments...). This allows the developer to quickly run the tests for the area they are working in as they work, only running the full set before committing their changes. In the past I've written test suites that can take several hours to complete in full!
	  6) I have not included any mechanism to navigate between pages as the scenario implies that one is not required for this exercise (YAGNI).