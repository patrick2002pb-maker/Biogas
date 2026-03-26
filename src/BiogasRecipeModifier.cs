using System;
using System.Collections.Generic;

namespace BiogasRecipeModifierNamespace
{
    public class BiogasRecipeModifier
    {
        private Dictionary<string, float> recipes;

        public BiogasRecipeModifier()
        {
            recipes = new Dictionary<string, float>();
        }

        public void AddRecipe(string ingredient, float yield)
        {
            if(!recipes.ContainsKey(ingredient))
            {
                recipes.Add(ingredient, yield);
            }
        }

        public void ModifyRecipe(string ingredient, float newYield)
        {
            if(recipes.ContainsKey(ingredient))
            {
                recipes[ingredient] = newYield;
            }
        }

        public void RemoveRecipe(string ingredient)
        {
            if(recipes.ContainsKey(ingredient))
            {
                recipes.Remove(ingredient);
            }
        }

        public float GetYield(string ingredient)
        {
            if(recipes.TryGetValue(ingredient, out float yield))
            {
                return yield;
            }
            return 0;
        }
    }
}