Main code is here:
https://github.com/juanflores01/AlliantAssmnt/blob/main/AlliantConsole/Program.cs
https://github.com/juanflores01/AlliantAssmnt/blob/main/AlliantLibrary/Methods.cs

Initial Pass

1.  Create Console, throw everything in the Main function, make sure it works and break it apart later.
2.  Create IEnumerable to count instance of each product type.
3.  Create IF statements to check for not-zero and apply both regular and bulk-discount pricing where applicable.
4.  Via console window, provide user input and item price total.
*.  tested - works.

Second Pass

1.  Cut the methods out of the Console Program class, paste them in a newly created Methods class in the Library Project.
2.  In Console project, add reference to Library project.
*.  tested - works.

Third Pass
*.  I realized that the methods class can go in the console project and library should've been a test project.
1.  Create Unit Test that includes methods for verifing scan of all products including multiples of a few, scan of multiples of a single product, scan of one of each product.