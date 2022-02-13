using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Test
    {
		public IList<IList<int>> subsets( int[] nums)

		{
            IList<IList<int>> result = new  List<IList<int>>();
			
			int tail= nums.Length;
        	int head = 0;
			int i = 0, j = 0;
			List<int> b = new List<int>();
			result.Add(b);
			while (head <= tail)
			{
				j = head;
				while (j <= tail)
				{
					List<int> a = new List<int>();
					for (i = head; i < j; i++)
					{
						a.Add(nums[i]);
						result.Add(a);

					}

					
					if (j<= tail) j++;



				}
				//j++;
				head++;

			}

			return result;
		}

		public void main()
		{
			// Input keys (use only 'a'
			// through 'z' and lower case)
			int[] keys = {1,2,3};

			String[] output = { "Not present in trie", "Present in trie" };

			IList<IList<int>> result = subsets(keys);

			foreach (var c in result)
			{
				Console.WriteLine(c.Count);
			}



		}

	}


}
