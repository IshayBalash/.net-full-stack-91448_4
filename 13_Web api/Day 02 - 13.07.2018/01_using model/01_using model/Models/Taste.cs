using System;


namespace _01_using_model.Controllers
{
    [Flags]
    public enum Taste
    {
        Sweetness = 1,
        Sourness = 2,
        Saltiness = 4,
        Bitterness = 8,
        Savoriness = 16
    }
}


        /*
        Logical operators: && (return true if both operands are true), 
                           || (return true if both any of the operands is true)



        Bitwise opertors: & (adds 2 bytes in a way that every bit is 1 if both bits in the sub action are 1),
                          | (adds 2 bytes in a way that every bit is 1 if any of the bits in the sub action is 1),


            -------
            EXAMPLE TO BITWUSE OPERATOR:

            byte num1: 0 0 1 0 1 0 0 1 
            byte num2: 0 0 0 0 1 0 1 1


            num1 & num2 = 0 0 0 0 1 0 0 1
            num1 | num2 = 0 0 1 0 1 0 1 1


            ---
            HEXA- DECIMAL DIGITS:

            0
            1
            2
            3
            4
            5
            6
            7
            8
            9
            A = 10
            B = 11
            C = 12
            D = 13
            E = 14
            F = 15


            ---
            CONVERTING HEXA-DECIMAL TO DECIMAL:

            128 (DECIMAL) = 1 * 10^2 + 2 * 10^1 + 8 * 10^0 = 128 (DECIMAL)
            80 (HEXA- DECIMAL) = 8 * 16^1 + 0 * 16^0  = 128 (DECIMAL)

        */
