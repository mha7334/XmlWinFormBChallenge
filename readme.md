Summary
-	The small App is developed using Winforms (Desktop App) and C# as the backend language. 
-	The input file is browsed using ‘OpenFileDialog’ class and the path of the file is saved into a readonly Textbox called ‘txtFile’
-	As the ‘Process’ button is clicked, it reads the xml file (specified in the text box) and de-serializes it into C# object called ‘WebOrder’
-	To handle the Date format (“yyyyMMdd”) properly during de-serialization, a little manual intervention was required. 
-	Two extra helper properties (AveragePrice and TotalPrice) are added.
-	In the end, the data from c# objects ‘WebOrder’ and ‘WebOrderItem’ are used to show the Customer Data Card on Winform UI. There has been taken care to format the AveragePrice and TotalPrice to show the thousand operator (dot) and decimal separator (comma) properly.
