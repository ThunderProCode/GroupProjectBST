namespace GroupProjectBST
{
    public static class Spelling
    {
        public static List<string> Fix(List<string> inputWords)
        {
            var dictionary = new Tree<string>();
            int inputWordCount = 0;
            int missingWordCount = 0;
            int foundWordCount = 0;
            List<string> outputWords = new List<string>();

            foreach (var word in inputWords)
            {
                if (dictionary.Find(word) != null)
                {
                    foundWordCount++;
                    if (foundWordCount % 3 == 0)
                    {
                        // Remove the word from the dictionary and add its successor if available
                        var successor = dictionary.Remove(word);
                        if (successor != null)
                        {
                            dictionary.Add(successor);
                            outputWords.Add(successor);
                        }
                    }
                    else
                    {
                        outputWords.Add(word);
                    }
                }
                else
                {

                    missingWordCount++;
                    if (missingWordCount % 3 == 0)
                    {
                        // Try to find a successor in the dictionary
                        var successor = dictionary.FindSuccessor(word);
                        if (successor != null)
                        {
                            outputWords.Add(successor);
                        }
                        else
                        {
                            dictionary.Add(word);
                            outputWords.Add(word);
                        }
                    }
                    else
                    {
                        dictionary.Add(word);
                        outputWords.Add(word);
                    }
                }

            }

            return outputWords;
        }
    }
}