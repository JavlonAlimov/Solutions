using System;

namespace LeetCodeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Test qilish uchun ma'lumotlar (Input)
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            // 2. Sizning yechimingizni ishga tushirish
            Solution solution = new Solution();
            int[] result = solution.TwoSum(nums, target);

            // 3. Natijani ekranga chiqarish
            // Agar natija topilsa, indekslarni chiqaradi
            Console.WriteLine($"Kiruvchi ma'lumot: [{string.Join(", ", nums)}], Target: {target}");
            Console.WriteLine($"Natija (Indexlar): [{result[0]}, {result[1]}]");
            
            // Ekranni ushlab turish uchun
            // Console.ReadLine(); 
        }
    }

    // --- SIZNING KODINGIZ (Chiroyli formatda) ---
    public class Solution 
    {
        public int[] TwoSum(int[] nums, int target) 
        {
            int[] arr = new int[2];
            
            for(int i = 0; i < nums.Length; i++ )
            {
                for(int j = 0; j < nums.Length; j++) 
                {
                    // O'ziga o'zini qo'shmaslik va takrorlamaslik uchun shart
                    if(i != j && i < j)
                    {
                        if(nums[i] + nums[j] == target)
                        {
                            // Sizning yozgan logikangiz:
                            for(int k = 0; k < 2; k += 2)
                            {
                                arr[k] = i;
                                arr[k + 1] = j;
                            }
                        }
                    }
                }
            }
            return arr;
        }
    }
}
