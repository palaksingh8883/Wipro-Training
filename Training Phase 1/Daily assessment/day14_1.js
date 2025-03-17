/*
Question 1:
even odd
Write a JavaScript function named checkOddEven that takes a number as a parameter and logs whether the number is odd or even to the console.

Requirements:

Define a function named checkOddEven that takes a parameter number. 

Log the result to the console.Your goal is to implement the checkOddEven function and test it with different numbers.

*/

// write your solution here
function checkOddEven(number) {
    //if (typeof number !== 'number' || isNaN(number)) {
            //console.log("Invalid input: Please provide a valid number.");
        if (number % 2 === 0) {
            console.log(number + " is even.");
        } else {
            console.log(number + " is odd.");
        }
    }
    
    // Testing the function with different numbers
    checkOddEven(5);   
    checkOddEven(10);  
    checkOddEven(7);  
    checkOddEven(2); 
