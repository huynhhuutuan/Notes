// https://www.geeksforgeeks.org/bitwise-operators-in-c-cpp/
// C Program to demonstrate use of bitwise operators
#include <stdio.h>
int main()
{
    // a = 5(00000101), b = 9(00001001)
    unsigned char a = 5, b = 9;
  
    // The result is 00000001
    printf("a = %d, b = %d\n", a, b);
    printf("a&b = %d\n", a & b);
  
    // The result is 00001101
    printf("a|b = %d\n", a | b);
  
    // The result is 00001100
    printf("a^b = %d\n", a ^ b);
  
    // The result is 11111010
    printf("~a = %d\n", a = ~a);
  
    // The result is 00010010
    printf("b<<1 = %d\n", b << 1);
  
    // The result is 00000100
    printf("b>>1 = %d\n", b >> 1);
  
    return 0;
}
/*
Output:
a = 5, b = 9
 a&b = 1
 a|b = 13
 a^b = 12
  ~a = 250
b<<1 = 18
b>>1 = 4
*/
  
// Java Left Shift Operator Example
class OperatorExample{  
	public static void main(String args[]){  
		System.out.println(10<<2);//10*2^2=10*4=40  
		System.out.println(10<<3);//10*2^3=10*8=80  
		System.out.println(20<<2);//20*2^2=20*4=80  
		System.out.println(15<<4);//15*2^4=15*16=240  
	}
}
/*
Output:
40
80
80
240
*/

// Java Right Shift Operator Example
class OperatorExample{  
	public static void main(String args[]){  
		System.out.println(10>>2);//10/2^2=10/4=2  
		System.out.println(20>>2);//20/2^2=20/4=5  
		System.out.println(20>>3);//20/2^3=20/8=2  
	}
}
/*
Output:
2
5
2
*/

// Java Shift Operator Example: >> vs >>>
class OperatorExample{  
	public static void main(String args[]){  
		//For positive number, >> and >>> works same  
		System.out.println(20>>2);  
		System.out.println(20>>>2);  
		//For negative number, >>> changes parity bit (MSB) to 0  
		System.out.println(-20>>2);  
		System.out.println(-20>>>2);  
	}
}
/*
Output:
5
5
-5
1073741819
*/
