package main

import "fmt"

func Sum(x int) int {
	if x == 0{
		return 0
	} else{
		return x+Sum(x-1)
	}
}

func Factorial(x int) int {
	if x == 0{
		return 1
	} else{
		return x*Factorial(x-1)
	}
}

func Fibonachi(x int) int {
	if x == 0 {
		return 0
	}else if x == 1 {
		return 1
	} else {
		return (Fibonachi(x-1) + Fibonachi(x-2))
	}
}

func main() {

	var num int
	fmt.Printf("Input x: ")
    fmt.Scanf("%d", &num)

	fmt.Println(Sum(num))
	fmt.Println(Factorial(num))
	fmt.Println(Fibonachi(num))
}