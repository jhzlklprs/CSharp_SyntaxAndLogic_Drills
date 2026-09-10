// ============================================================
// Syntax & Logic Structure Drills
//
// The point of this set isn't "get the right answer" — it's
// building the habit of PLANNING before typing.
//
// For EVERY challenge below, do this in order:
//   1. Write your plan as plain-English comments FIRST
//      (e.g. "// group by department, then count each group")
//   2. THEN write the code
//   3. Run it, compare to Expected
//
// If you blank on step 2 (syntax) even though step 1 was easy —
// that's a syntax gap, drill it.
// If step 1 itself is hard — that's a logic-structure gap,
// slow down and think in steps before touching code.
// ============================================================


#region -- Drill 1 — No LINQ, just structure (loops + conditionals) --

// Given a list of exam scores, print "Pass" if the score is >= 60,
// otherwise print "Fail" — using a plain foreach + if/else
// (no LINQ allowed here on purpose — this is pure control-flow practice).
//
// First is to target those data in foreach, then inside foreach I will use if/else condition to target "Pass" and "Fail".
// // TODO: plan first (as comments), then code
// List<int> scores = new List<int> { 45, 72, 60, 88, 59, 91 };
// int passCount = 0;
// int failCount = 0;
// foreach (int s in scores)
// {
//     if (s >= 60)
//     {
//         Console.WriteLine("Pass");
//         passCount++;
//     }
//     else
//     {
//         Console.WriteLine("Fail");
//         failCount++;
//     }
// }

// Console.WriteLine($"Passed: {passCount}, Failed: {failCount}");
//
// Expected output:
// Fail
// Pass
// Pass
// Pass
// Fail
// Pass


// -- Drill 1b — Same data, but count instead of print --
// Count how many students passed and how many failed, using a loop
// and two counter variables (still no LINQ).

// TODO
// Expected: Passed: 4, Failed: 2

#endregion


#region -- Drill 2 — Nested loops (logic structure focus) --

// Print a small multiplication table from 1 to 5 (5x5 grid).
// This requires a loop INSIDE a loop — plan the outer loop
// (rows) and inner loop (columns) separately before coding.

//My plan is to create first an array consist of 1-5, then use loop for multiplication, just thinking the proper syntax for it.

// TODO


// int[] numbers = {1, 2, 3, 4, 5};

// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         Console.Write(numbers[i] * numbers[j] + " ");
//     }
//     Console.WriteLine();
// }
//
// Expected output (first 2 rows shown):
// 1 2 3 4 5
// 2 4 6 8 10
// ... (continues to row 5)

#endregion


#region -- Drill 3 — Translate English to LINQ (syntax focus) --

// Each line below is a plan already written in English.
// Your only job is translating it into correct LINQ syntax.
// This isolates the syntax skill — the thinking is done for you.

// List<int> numbers = new List<int> { 4, 8, 15, 16, 23, 42, 1, 7 };

// 3a: "Keep only numbers greater than 10"
// TODO

// 3b: "Turn each number into its square"
// TODO

// 3c: "Get the smallest number in the list"
// TODO

// 3d: "Check if ANY number is negative"
// TODO

// 3e: "Check if ALL numbers are positive"
// TODO

// 3f: "Sort the numbers from highest to lowest"
// TODO

#endregion


#region -- Drill 4 — Translate LINQ to English (reverse direction) --

// This time, the code is given. Before running it, write in a comment
// what you THINK it does and what it will print. Then run it and check
// if your prediction was right. This trains reading comprehension,
// which is just as important as writing.

// List<string> names = new List<string> { "Mia", "Bo", "Alexander", "Sam", "Cleo" };
// var result = names.Where(n => n.Length > 3).OrderBy(n => n.Length).ToList();
//
// // TODO: write your prediction here BEFORE running
// foreach (var r in result) Console.WriteLine(r);


// List<int> numbers = new List<int> { 5, 12, 8, 20, 3, 17 };
// var result2 = numbers.Where(n => n % 2 == 0).Select(n => n * 10).Sum();
//
// // TODO: write your prediction here BEFORE running
// Console.WriteLine(result2);

#endregion


#region -- Drill 5 — Build the plan yourself (no scaffolding) --

// This one has NO hints in the comments — you decide the whole
// approach. Write your plan first, in your own words, before coding.

// You have a list of products, each with a Name, Category, and Price.
// Task: Print each Category along with the average price of products
// in that category, sorted from most expensive average to least.

// record Product(string Name, string Category, double Price);
//
// List<Product> products = new List<Product>
// {
//     new Product("Laptop", "Electronics", 1200),
//     new Product("Mouse", "Electronics", 25),
//     new Product("Desk", "Furniture", 300),
//     new Product("Chair", "Furniture", 150),
//     new Product("Monitor", "Electronics", 400),
//     new Product("Bookshelf", "Furniture", 200)
// };
//
// TODO: your plan, then your code
//
// Expected order: Electronics (avg 541.67), Furniture (avg 216.67)

#endregion


#region -- Drill 6 — Debug it (syntax spotting) --

// The code below has 3 syntax errors. Find and fix them WITHOUT
// running it first — just by reading. Then run it to confirm.

// List<int> numbers = new List<int> { 1, 2, 3, 4, 5 }
// var evens = numbers.Where(n => n % 2 = 0);
// foreach (var n in evens)
//     Console.Writeline(n)

// Expected once fixed: 2, 4

#endregion


#region -- Drill 7 — Boss Fight: Plan-first, no peeking 😈 --

// A bookstore has orders. Each order has a Customer, Book title,
// and Quantity. Without looking at any previous exercise for
// reference, write out your plan for the following, THEN code it:
//
// "Find the customer who has ordered the MOST total books
//  (summed across all their orders), and print their name
//  and total quantity."
//
// record Order(string Customer, string Book, int Quantity);
//
// List<Order> orders = new List<Order>
// {
//     new Order("Mia", "Dune", 2),
//     new Order("Leo", "1984", 1),
//     new Order("Mia", "Foundation", 3),
//     new Order("Sam", "Dune", 5),
//     new Order("Leo", "Neuromancer", 4)
// };
//
// TODO: plan (in your own words) then code
//
// Expected: Sam: 5   (Mia has 5 too — actually a tie! what does your
// code do with a tie? Think about that before checking — it's on
// purpose, ties are a real thing you'll hit constantly in reporting code.)

#endregion