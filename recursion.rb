def Factorial(x)
    if x == 0
        return 1
    else
        return x*Factorial(x-1)
    end
end

def Sum(x)
    if x == 0
        return 0
    else
        return x+Sum(x-1)
    end
end

def Fibonachi(x)
    if x == 0
        return 0
    elsif x == 1
        return 1
    else
        return Fibonachi(x-1) + Fibonachi(x-2)
    end
end

printf("Input number: ")
number = gets.encode('UTF-8').chomp.to_i
puts "Sum(x) = #{Sum(number)}"
puts "Factorial(x) = #{Factorial(number)}"
puts "Fibonachi(x) = #{Fibonachi(number)}"