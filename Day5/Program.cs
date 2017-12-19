﻿using System;

namespace Day5
{
	internal class Program
	{
		private static void Main()
		{
			const string PUZZLEINPUT = "2\r\n0\r\n0\r\n1\r\n2\r\n0\r\n1\r\n-4\r\n-5\r\n0\r\n-1\r\n0\r\n-6\r\n0\r\n-5\r\n2\r\n-9\r\n-11\r\n-15\r\n-3\r\n-11\r\n-12\r\n-14\r\n-5\r\n-16\r\n-3\r\n-13\r\n-6\r\n0\r\n-3\r\n-17\r\n0\r\n-17\r\n-5\r\n-1\r\n-26\r\n-21\r\n-14\r\n-20\r\n-7\r\n-24\r\n-26\r\n-32\r\n-41\r\n-2\r\n-18\r\n-18\r\n-13\r\n-28\r\n0\r\n-32\r\n-3\r\n-2\r\n-14\r\n-17\r\n-54\r\n-22\r\n-34\r\n-33\r\n-34\r\n0\r\n-46\r\n-3\r\n-44\r\n-58\r\n-10\r\n-56\r\n-65\r\n-46\r\n-24\r\n-20\r\n-4\r\n-27\r\n-41\r\n-33\r\n-31\r\n-20\r\n-75\r\n-73\r\n-41\r\n-36\r\n-31\r\n-70\r\n-46\r\n-1\r\n-79\r\n-61\r\n-51\r\n-77\r\n-44\r\n-55\r\n-2\r\n-18\r\n-26\r\n-50\r\n-79\r\n-59\r\n-69\r\n-62\r\n-80\r\n-13\r\n-69\r\n-97\r\n-71\r\n-24\r\n-7\r\n-40\r\n-10\r\n-23\r\n-85\r\n-97\r\n-103\r\n-55\r\n-90\r\n-40\r\n-60\r\n-98\r\n-95\r\n-39\r\n-76\r\n-63\r\n-12\r\n-2\r\n-65\r\n-109\r\n-47\r\n-12\r\n-37\r\n-5\r\n-23\r\n-125\r\n-124\r\n-49\r\n-91\r\n-70\r\n-134\r\n-54\r\n-122\r\n-135\r\n-12\r\n-23\r\n-22\r\n-83\r\n-40\r\n-133\r\n-77\r\n-88\r\n-119\r\n-146\r\n-26\r\n-12\r\n-108\r\n-63\r\n-111\r\n-148\r\n-99\r\n-77\r\n-77\r\n-76\r\n-89\r\n-37\r\n-95\r\n-105\r\n-76\r\n-137\r\n-151\r\n-146\r\n-141\r\n-162\r\n-12\r\n-68\r\n-36\r\n-116\r\n-60\r\n-73\r\n-61\r\n-60\r\n-101\r\n-168\r\n-142\r\n-143\r\n-118\r\n-165\r\n-108\r\n-179\r\n-180\r\n-11\r\n-152\r\n-67\r\n-33\r\n-10\r\n-169\r\n-155\r\n-16\r\n-136\r\n-165\r\n-164\r\n2\r\n1\r\n-28\r\n-131\r\n-86\r\n-153\r\n-116\r\n-113\r\n-149\r\n-66\r\n-64\r\n-36\r\n-168\r\n-116\r\n-159\r\n-15\r\n-180\r\n-125\r\n-146\r\n-135\r\n-105\r\n-161\r\n-133\r\n-207\r\n-192\r\n-192\r\n-99\r\n-146\r\n-93\r\n-21\r\n-5\r\n-189\r\n-86\r\n-16\r\n-4\r\n-44\r\n-167\r\n-20\r\n-201\r\n-110\r\n-103\r\n-223\r\n-182\r\n-71\r\n-194\r\n-68\r\n-90\r\n-237\r\n-147\r\n2\r\n-88\r\n-184\r\n-90\r\n-12\r\n-119\r\n-85\r\n-138\r\n-179\r\n-152\r\n-158\r\n-82\r\n-122\r\n-179\r\n-191\r\n-120\r\n-174\r\n-165\r\n-137\r\n-181\r\n-58\r\n-250\r\n-66\r\n-194\r\n-202\r\n-171\r\n-179\r\n-137\r\n-250\r\n-248\r\n-167\r\n-108\r\n-27\r\n-175\r\n-34\r\n-254\r\n-35\r\n-157\r\n-158\r\n-31\r\n-52\r\n-236\r\n-238\r\n-247\r\n-279\r\n-209\r\n-257\r\n-167\r\n-151\r\n-7\r\n-182\r\n-2\r\n-149\r\n-87\r\n-245\r\n-141\r\n-238\r\n-186\r\n-71\r\n-97\r\n-128\r\n-147\r\n-52\r\n-93\r\n-142\r\n-197\r\n-296\r\n-73\r\n-89\r\n-14\r\n-253\r\n-190\r\n-295\r\n-312\r\n-47\r\n-236\r\n-233\r\n-238\r\n-305\r\n-121\r\n-191\r\n-251\r\n-91\r\n-307\r\n-77\r\n-228\r\n-300\r\n-197\r\n-91\r\n-191\r\n-299\r\n-77\r\n-255\r\n-51\r\n-232\r\n-64\r\n-198\r\n-187\r\n-96\r\n-86\r\n-203\r\n-216\r\n-203\r\n-343\r\n-203\r\n-78\r\n-99\r\n-174\r\n-269\r\n-349\r\n-173\r\n-52\r\n-233\r\n-154\r\n-151\r\n-304\r\n-70\r\n-235\r\n-106\r\n-226\r\n-325\r\n-142\r\n-192\r\n-115\r\n-170\r\n-15\r\n-35\r\n-174\r\n-267\r\n-108\r\n-374\r\n-128\r\n-60\r\n-131\r\n-364\r\n-371\r\n-56\r\n-96\r\n-365\r\n-305\r\n-140\r\n-50\r\n-220\r\n-179\r\n-43\r\n-356\r\n-120\r\n-216\r\n-276\r\n-103\r\n-389\r\n-28\r\n-393\r\n-341\r\n-74\r\n-85\r\n-361\r\n-68\r\n-111\r\n-4\r\n-216\r\n-263\r\n-115\r\n-194\r\n-382\r\n-285\r\n-176\r\n-145\r\n-24\r\n-59\r\n-291\r\n-170\r\n-358\r\n-226\r\n-355\r\n-292\r\n-185\r\n-297\r\n-156\r\n-248\r\n-332\r\n-319\r\n-311\r\n-46\r\n-170\r\n-428\r\n-222\r\n-35\r\n-136\r\n-206\r\n-81\r\n-330\r\n-89\r\n-75\r\n-248\r\n-42\r\n-52\r\n-24\r\n-39\r\n-129\r\n-228\r\n-242\r\n-396\r\n-222\r\n-433\r\n-168\r\n-362\r\n-4\r\n-345\r\n-395\r\n-435\r\n-14\r\n-439\r\n-136\r\n-267\r\n-417\r\n-107\r\n-177\r\n-8\r\n-208\r\n-219\r\n-222\r\n-453\r\n-155\r\n-183\r\n-252\r\n0\r\n-173\r\n-71\r\n-164\r\n-187\r\n-80\r\n-292\r\n-246\r\n-89\r\n-217\r\n-227\r\n-93\r\n-244\r\n-82\r\n-51\r\n-23\r\n-283\r\n-261\r\n-50\r\n-384\r\n-415\r\n-149\r\n-103\r\n-481\r\n-404\r\n-267\r\n-80\r\n-61\r\n-130\r\n-228\r\n-310\r\n-319\r\n-186\r\n-88\r\n-173\r\n-40\r\n-69\r\n-231\r\n-398\r\n-342\r\n-176\r\n-33\r\n-304\r\n-232\r\n-220\r\n-381\r\n-436\r\n-74\r\n-116\r\n-398\r\n-467\r\n-341\r\n-483\r\n-137\r\n-5\r\n-437\r\n-67\r\n-296\r\n-137\r\n-166\r\n-216\r\n-192\r\n-307\r\n-68\r\n-319\r\n-296\r\n-524\r\n-308\r\n-68\r\n-21\r\n-515\r\n-531\r\n-221\r\n-173\r\n-261\r\n-200\r\n-450\r\n-95\r\n-366\r\n-14\r\n-29\r\n-23\r\n-173\r\n-397\r\n-373\r\n-283\r\n-104\r\n-246\r\n-153\r\n-240\r\n-378\r\n-306\r\n-495\r\n-518\r\n-459\r\n-459\r\n-340\r\n-475\r\n-96\r\n-347\r\n-8\r\n-365\r\n-7\r\n-482\r\n-113\r\n-223\r\n-313\r\n-456\r\n-89\r\n-205\r\n-507\r\n-538\r\n-115\r\n-310\r\n-484\r\n-96\r\n-367\r\n-582\r\n-32\r\n-550\r\n-247\r\n-257\r\n-479\r\n-165\r\n-346\r\n-514\r\n-188\r\n-180\r\n-506\r\n-117\r\n-92\r\n-128\r\n-507\r\n-387\r\n-52\r\n-535\r\n-210\r\n-221\r\n-560\r\n-245\r\n-70\r\n-552\r\n-99\r\n-529\r\n-607\r\n-263\r\n-345\r\n-253\r\n-426\r\n-351\r\n-92\r\n-489\r\n-478\r\n-226\r\n-606\r\n-287\r\n-277\r\n-432\r\n-336\r\n-418\r\n-94\r\n-2\r\n-192\r\n-600\r\n-454\r\n-26\r\n-3\r\n-630\r\n-294\r\n-105\r\n-439\r\n-589\r\n-425\r\n-623\r\n-451\r\n-487\r\n-117\r\n-538\r\n-78\r\n-126\r\n-485\r\n-326\r\n-455\r\n-370\r\n-389\r\n-379\r\n-158\r\n-441\r\n-524\r\n-435\r\n-160\r\n-198\r\n-172\r\n-313\r\n-380\r\n-128\r\n-166\r\n-562\r\n-427\r\n-23\r\n-616\r\n-95\r\n-188\r\n-417\r\n-419\r\n-589\r\n-488\r\n-377\r\n-520\r\n-412\r\n-348\r\n-359\r\n-488\r\n-108\r\n-409\r\n-56\r\n-460\r\n-364\r\n-233\r\n-352\r\n-59\r\n-313\r\n-609\r\n-534\r\n-432\r\n-104\r\n-514\r\n-68\r\n-83\r\n-305\r\n-308\r\n-645\r\n-535\r\n-624\r\n-453\r\n-630\r\n-274\r\n-98\r\n-280\r\n-38\r\n-443\r\n-620\r\n-411\r\n-624\r\n-379\r\n-373\r\n-338\r\n-410\r\n-382\r\n-171\r\n-645\r\n-430\r\n-294\r\n-696\r\n-513\r\n-659\r\n-690\r\n-558\r\n-2\r\n-325\r\n-234\r\n-437\r\n-610\r\n-158\r\n-186\r\n-539\r\n-405\r\n-78\r\n-100\r\n-311\r\n-201\r\n-558\r\n-604\r\n-386\r\n-457\r\n-125\r\n-419\r\n-680\r\n-147\r\n-237\r\n-107\r\n-155\r\n-550\r\n-565\r\n-214\r\n-528\r\n-353\r\n-637\r\n-6\r\n-634\r\n-332\r\n-92\r\n-474\r\n-289\r\n-617\r\n-141\r\n-398\r\n-367\r\n-537\r\n-369\r\n-88\r\n-608\r\n-699\r\n-257\r\n-602\r\n-276\r\n-406\r\n-92\r\n-746\r\n-398\r\n-387\r\n-234\r\n-331\r\n-225\r\n-480\r\n-667\r\n-264\r\n-299\r\n-673\r\n-265\r\n-142\r\n-512\r\n-573\r\n-508\r\n-551\r\n-471\r\n-270\r\n-328\r\n-648\r\n-625\r\n-779\r\n-232\r\n-393\r\n-749\r\n-84\r\n-240\r\n-59\r\n-220\r\n-55\r\n-224\r\n-350\r\n-130\r\n-23\r\n-239\r\n-105\r\n-2\r\n-762\r\n-702\r\n-163\r\n-94\r\n-350\r\n-11\r\n-176\r\n-43\r\n-654\r\n-136\r\n-348\r\n-215\r\n-67\r\n-599\r\n-757\r\n-636\r\n-367\r\n-61\r\n-209\r\n-623\r\n-342\r\n-111\r\n-93\r\n-14\r\n-613\r\n-362\r\n-837\r\n-734\r\n-468\r\n-803\r\n-548\r\n-699\r\n-744\r\n-429\r\n-243\r\n-633\r\n-382\r\n-780\r\n-668\r\n-498\r\n-664\r\n-539\r\n-781\r\n-525\r\n-697\r\n-715\r\n-126\r\n-276\r\n-504\r\n-175\r\n-592\r\n-688\r\n-92\r\n-548\r\n-298\r\n-33\r\n-532\r\n-674\r\n-57\r\n-531\r\n-488\r\n-310\r\n-90\r\n-757\r\n-496\r\n-132\r\n-733\r\n-701\r\n-61\r\n-797\r\n-215\r\n-319\r\n-700\r\n-295\r\n-572\r\n-41\r\n-140\r\n-176\r\n-479\r\n-560\r\n-164\r\n-338\r\n-794\r\n-132\r\n-453\r\n-709\r\n-445\r\n-802\r\n2\r\n-336\r\n-562\r\n-802\r\n-878\r\n-547\r\n-368\r\n-502\r\n-574\r\n-275\r\n-687\r\n-560\r\n-432\r\n-423\r\n-174\r\n-367\r\n-59\r\n-605\r\n-340\r\n-626\r\n-142\r\n-601\r\n-488\r\n-299\r\n-466\r\n-521\r\n-783\r\n-140\r\n-731\r\n-779\r\n-252\r\n-663\r\n-906\r\n-410\r\n-601\r\n-524\r\n-332\r\n-750\r\n-556\r\n-730\r\n-749\r\n-294\r\n-798\r\n-93\r\n-345\r\n-316\r\n-186\r\n-634\r\n-904\r\n-237\r\n-134\r\n-765\r\n-953\r\n-170\r\n-854\r\n-910\r\n-99\r\n-782\r\n-564\r\n-505\r\n-49\r\n-827\r\n-64\r\n-297\r\n-548\r\n-841\r\n-598\r\n-414\r\n-184\r\n-67\r\n-99\r\n-880\r\n-855\r\n-722\r\n-725\r\n-582\r\n-416\r\n-473\r\n-339\r\n-491\r\n-162\r\n-311\r\n-43\r\n-938\r\n-608\r\n-524\r\n-212\r\n-4\r\n-945\r\n-544\r\n-879\r\n-382\r\n-21\r\n-512\r\n-169\r\n-284\r\n-140\r\n-588\r\n-407\r\n-56\r\n-610\r\n-75\r\n-412\r\n-321\r\n-801\r\n-881\r\n-220\r\n-388\r\n-116\r\n-962\r\n-1007\r\n-862\r\n-20\r\n-409\r\n-116\r\n-943\r\n-558\r\n-1001\r\n-548\r\n-302\r\n-165\r\n-730\r\n-1012\r\n-669\r\n-875\r\n-393\r\n-979";
			string[] instructions = PUZZLEINPUT.Replace("\r", string.Empty).Split('\n');

			InstructionParser ip = new InstructionParser();
			int stepsTaken = ip.Part1(instructions);
			Console.WriteLine($"Part 1: {stepsTaken}");

			// Array is a reference type, so we need to "re-do" it, or we'll be passing a mutated array.
			instructions = PUZZLEINPUT.Replace("\r", string.Empty).Split('\n');
			stepsTaken = ip.Part2(instructions);
			Console.WriteLine($"Part 2: {stepsTaken}");

			Console.ReadKey();
		}
	}

	public class InstructionParser
	{
		public int Part1(string[] input)
		{
			int steps = 0;

			int currentStepIndex = 0;
			while (currentStepIndex < input.Length)
			{
				int currentStep = int.Parse(input[currentStepIndex]);

				int nextStepIndex = currentStepIndex + currentStep;
				input[currentStepIndex] = (currentStep + 1).ToString();
				steps++;
				currentStepIndex = nextStepIndex;
			}

			return steps;
		}

		public int Part2(string[] input)
		{
			int steps = 0;

			int currentStepIndex = 0;
			while (currentStepIndex < input.Length)
			{
				int currentStep = int.Parse(input[currentStepIndex]);

				int nextStepIndex = currentStepIndex + currentStep;
				input[currentStepIndex] = (currentStep + (currentStep >= 3 ? -1 : 1)).ToString();
				steps++;
				currentStepIndex = nextStepIndex;
			}

			return steps;
		}
	}
}