# CoolShop CSV Orders Processor

## Description
This C# console application reads orders from a CSV file (`Ordini.csv`) and prints summary information to the console.  

The program calculates:

- Order with the **highest unit price**
- Article with the **highest quantity**
- Total price of all orders **without discount**
- Total price of all orders **with discount**

---

## Files

- **Program.cs** — Main program that reads the CSV, parses each row into an `Order`, and prints results.  
- **Order.cs** (optional) — Class representing a single order with properties:
  - `Id`, `ArticleName`, `Quantity`, `Price`, `PercentageDiscount`, `Buyer`

---

## CSV Input (`Ordini.csv`)

- Must be located in the same folder as the program.  
- **Delimiter:** semicolon (`;`)  
- **Columns (in order):**
  1. Id (int)
  2. ArticleName (string)
  3. Quantity (int)
  4. Price (double) — unit price
  5. PercentageDiscount (double) — discount percentage
  6. Buyer (string)


---

## How it Works

1. Reads the CSV file line by line.  
2. Splits each line by semicolon (`;`).  
3. Parses fields into the correct types (`int`, `double`, `string`).  
4. Stores valid orders in a list (`List<Order>`).  
5. Skips invalid lines with an error message.  
6. Uses LINQ to calculate:
   - Highest unit price
   - Highest quantity
   - Total price without discount
   - Total price with discount  
7. Prints the results to the console.

---

## How to Run

1. Make sure `Ordini.csv` is in the program folder.  
2. Go to Program.cs and start debugging


