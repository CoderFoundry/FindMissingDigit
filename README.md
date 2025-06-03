# Find Missing Digit – Coding Challenge Solution

Welcome! This repository contains a C# solution to the popular "Find the Missing Digit" coding challenge. Whether you’re prepping for interviews, leveling up your skills, or following along with our [YouTube tutorial](https://www.youtube.com/your-video-link), you’re in the right place.

[![Watch the video](https://img.youtube.com/vi/YOUR_VIDEO_ID/0.jpg)](https://www.youtube.com/your-video-link)

Check out the full walkthrough on YouTube that breaks down the challenge and shows you how to solve it.

## About the Challenge

The “Find the Missing Digit” coding challenge is a classic problem often encountered in interviews, coding bootcamps, and online platforms like LeetCode or CodeSignal. It tests your ability to manipulate strings, arithmetic logic, and handle edge cases.

### The Problem Statement

You are given a simple arithmetic equation where **exactly one digit (0-9) has been replaced with a question mark (`?`)**. Your task is to determine which digit belongs in the place of `?` so that the equation is valid. 


**Example:**

Input: `"1? + 23 = 35"`  
Output: `2` (because 12 + 23 = 35)

Input: `"31 - ?2 = 150"`  
Output: `-1` (because no digit can result in `150`)

---

### Constraints

- Your code must handle the following operations:
  - **Addition (`+`)**
  - **Subtraction (`-`)**
  - **Multiplication (`*`)**
  - **Division (`/`)** (integer division only, no remainders, and never divide by zero)

- The `?` can appear anywhere in the numbers on the left or right of the equation.
- There will only be one missing digit.
- Equations will always be provided as a string, and should be formatted as `"{integer} {operator} {integer} = {integer}"`.
- Return `-1` if it is impossible to create a mathematically correct equation or invalid input was received.

### Edge Cases

- Division by zero must be avoided.
- Expressions with multiple `?` should be rejected or handled appropriately (the provided code assumes only one `?`).
- Ensure all numbers are valid integers after replacement.
- Reject answers that would result in numbers like `012` or `00` (not valid integers).

---

### What You Learn by Solving This

- **String manipulation and parsing**—critical for real-world data processing.
- **Defensive coding**—validating inputs, avoiding runtime errors, handling unexpected or malformed data.
- **Understanding problem requirements**—paying close attention to rules like “no leading zeros” or valid math.

Keep practicing challenges like this to build up the instincts and skills you need to excel in real-world coding and interviews!

## 🚀 Ready to Go Pro?

Are you looking for your **first developer job** or preparing to take the next step in your tech career?  
At [learn.coderfoundry.com](https://learn.coderfoundry.com), you’ll find:

- **Job-focused, curated courses** that teach you exactly what employers want
- **Project-based learning** so you can build real-world portfolio apps
- Practical interview prep and coding challenges to help you stand out

**Whether you’re just starting out or leveling up for your next opportunity, our training will help you go pro.**  
[Start your journey today!](https://learn.coderfoundry.com)

## Try It Yourself

Clone the repo and run the solution:

```bash
git clone https://github.com/CoderFoundry/FindMissingDigit
cd FindMissingDigit

# run the application
dotnet run --project FindMissingDigit

# or run the included unit tests
dotnet test
```
