using System;

class OTPGenerator{
    static int GenerateOTP()    {
        Random random = new Random();
        return random.Next(100000, 1000000);
    }

    static bool AreOTPsUnique(int[] otps){
        for (int i = 0; i < otps.Length; i++){
            for (int j = i + 1; j < otps.Length; j++){
                if (otps[i] == otps[j]){
                    return false;
                }
            }
        }
        return true;
    }

    static void Main(){
        int[] otpArray = new int[10];

        for (int i = 0; i < otpArray.Length; i++){
            otpArray[i] = GenerateOTP();
            Console.WriteLine(otpArray[i]);
        }

        bool result = AreOTPsUnique(otpArray);

        if (result)    Console.WriteLine("** All OTPs are UNIQUE **");
        else    Console.WriteLine(" Attention Duplicate OTPs found !! ");
    }
}
