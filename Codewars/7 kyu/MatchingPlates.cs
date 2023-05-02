using System;

class Kata{
  public static bool matchingPlates(char[] meals, char[] stack)
  {
            char[] mealCountStack = new char[stack.Length];
            if (meals.Length > stack.Length) return false;
            if (meals.Length <= stack.Length)
            {
                for (int i = 0; i < meals.Length; i++)
                {
                    mealCountStack[i] = meals[i];
                }
            }
            for (int i = 0; i < mealCountStack.Length; i++)
            {
                if (mealCountStack[i] != stack[i] && mealCountStack[i] != '\0') return false;
            }
            return true;
  }
}