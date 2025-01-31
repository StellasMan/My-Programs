using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionTest
{
	public partial class CollectionForm : Form
	{
		enum COLL_TYPE
		{
			CT_QUEUE = 1,
			CT_STACK,
			CT_SORTEDLIST
		};

		enum CONT_TYPE
		{
			CO_INTEGER,
			CO_STRING,
			CO_OBJECT
		};

		Stack<Int32> stackInt = new Stack<Int32>();
		Stack<String> stackString = new Stack<String>();
		Stack<Object> stackObject = new Stack<Object>();

		Queue<Int32> queueInt = new Queue<Int32>();
		Queue<String> queueString = new Queue<String>();
		Queue<Object> queueObject = new Queue<Object>();

		SortedList<Int32, String> sListInt = new SortedList<Int32, String>();
		SortedList<String, String> sListString = new SortedList<String, String>();
		SortedList<Object, String> sListObject = new SortedList<Object, String>();

		public CollectionForm()
		{
			InitializeComponent();
		}

		private void OnAdd(object sender, EventArgs e)
		{
			COLL_TYPE enumCollType = radioQueue.Checked ? COLL_TYPE.CT_QUEUE : radioStack.Checked ? COLL_TYPE.CT_STACK : COLL_TYPE.CT_SORTEDLIST;
			CONT_TYPE enumContType = radioInteger.Checked ? CONT_TYPE.CO_INTEGER : radioString.Checked ? CONT_TYPE.CO_STRING : CONT_TYPE.CO_OBJECT;
			int nCount = (int)updItemCount.Value;

			String sContainerType = (enumContType == CONT_TYPE.CO_INTEGER) ? "Integers" : (enumContType == CONT_TYPE.CO_STRING) ? "Strings" : "Objects";
			String sContentType = (enumCollType == COLL_TYPE.CT_QUEUE) ? "Queue" : (enumCollType == COLL_TYPE.CT_STACK) ? "Stack" : "Sorted List";

			String szMsg = String.Format(
						"**** Adding {0} {1} to {2} ****\n",
						nCount,
						sContainerType,
						sContentType);

			Trace.Write(szMsg);

			txtStatus.Clear();
			txtStatus.AppendText(szMsg);

			try
			{
				switch (enumCollType)
				{
					case COLL_TYPE.CT_QUEUE:
						{
							switch (enumContType)
							{
								case CONT_TYPE.CO_INTEGER:
									AddItemsToQueue<int>(queueInt, nCount);
									break;

								case CONT_TYPE.CO_STRING:
									AddItemsToQueue<String>(queueString, nCount);
									break;

								case CONT_TYPE.CO_OBJECT:
									AddItemsToQueue<Object>(queueObject, nCount);
									break;
							}
						}
						break;

					case COLL_TYPE.CT_STACK:
						{
							switch (enumContType)
							{
								case CONT_TYPE.CO_INTEGER:
									AddItemsToStack<int>(stackInt, nCount);
									break;

								case CONT_TYPE.CO_STRING:
									AddItemsToStack<String>(stackString, nCount);
									break;

								case CONT_TYPE.CO_OBJECT:
									// AddObjectsToStack(nCount);
									AddItemsToStack<Object>(stackObject, nCount);
									break;
							}
						}
						break;

					case COLL_TYPE.CT_SORTEDLIST:
						{
							switch (enumContType)
							{
								case CONT_TYPE.CO_INTEGER:
									AddItemsToSortedList<int>(sListInt, nCount);
									break;

								case CONT_TYPE.CO_STRING:
									AddItemsToSortedList<String>(sListString, nCount);
									break;

								case CONT_TYPE.CO_OBJECT:
									AddItemsToSortedList<Object>(sListObject, nCount);
									break;
							}
						}
						break;
				}
			}
			catch (Exception ex)
			{
				szMsg = String.Format("General exception attempting to add {0} {1} from {2}.\n{3}\n", nCount, sContainerType, sContentType, ex.Message);
				Trace.Write(szMsg);
				txtStatus.AppendText(szMsg);
			}
		}

		private void OnRemove(object sender, EventArgs e)
		{
			COLL_TYPE enumCollType = radioQueue.Checked ? COLL_TYPE.CT_QUEUE : radioStack.Checked ? COLL_TYPE.CT_STACK : COLL_TYPE.CT_SORTEDLIST;
			CONT_TYPE enumContType = radioInteger.Checked ? CONT_TYPE.CO_INTEGER : radioString.Checked ? CONT_TYPE.CO_STRING : CONT_TYPE.CO_OBJECT;
			int nCount = (int)updItemCount.Value;

			String sContainerType = (enumContType == CONT_TYPE.CO_INTEGER) ? "Integers" : (enumContType == CONT_TYPE.CO_STRING) ? "Strings" : "Objects";
			String sContentType = (enumCollType == COLL_TYPE.CT_QUEUE) ? "Queue" : (enumCollType == COLL_TYPE.CT_STACK) ? "Stack" : "Sorted List";

			String szMsg = String.Format(
						"Removing {0} {1} from {2}\n",
						nCount,
						sContainerType,
						sContentType);

			Trace.WriteLine(szMsg);

			txtStatus.Clear();
			txtStatus.AppendText(szMsg);

			try
			{
				switch (enumCollType)
				{
					case COLL_TYPE.CT_QUEUE:
						{
							switch (enumContType)
							{
								case CONT_TYPE.CO_INTEGER:
									RemoveItemsFromQueue<int>(queueInt, nCount);
									break;

								case CONT_TYPE.CO_STRING:
									RemoveItemsFromQueue<String>(queueString, nCount);
									break;

								case CONT_TYPE.CO_OBJECT:
									RemoveItemsFromQueue<Object>(queueObject, nCount);
									break;
							}
						}
						break;

					case COLL_TYPE.CT_STACK:
						{
							switch (enumContType)
							{
								case CONT_TYPE.CO_INTEGER:
									RemoveItemsFromStack<int>(stackInt, nCount);
									break;

								case CONT_TYPE.CO_STRING:
									RemoveItemsFromStack<String>(stackString, nCount);
									break;

								case CONT_TYPE.CO_OBJECT:
									RemoveItemsFromStack<Object>(stackObject, nCount);
									break;
							}
						}
						break;

					case COLL_TYPE.CT_SORTEDLIST:
						{
							switch (enumContType)
							{
								case CONT_TYPE.CO_INTEGER:
									RemoveItemsFromSortedList<int>(sListInt, nCount);
									break;

								case CONT_TYPE.CO_STRING:
									RemoveItemsFromSortedList<String>(sListString, nCount);
									break;

								case CONT_TYPE.CO_OBJECT:
									RemoveItemsFromSortedList<Object>(sListObject, nCount);
									break;
							}
						}
						break;
				}
			}
			catch (InvalidOperationException ex)
			{
				szMsg = String.Format("Invalid Operation exception attempting to remove {0} {1} from {2}.\n{3}\n", nCount, sContainerType, sContentType, ex.Message);
				Trace.Write(szMsg);
				txtStatus.AppendText(szMsg);
			}
			catch (IndexOutOfRangeException ex)
			{
				szMsg = String.Format("Indexing exception attempting to remove {0} {1} from {2}.\n{3}\n", nCount, sContainerType, sContentType, ex.Message);
				Trace.Write(szMsg);
				txtStatus.AppendText(szMsg);
			}
			catch (Exception ex)
			{
				szMsg = String.Format("General exception attempting to remove {0} {1} from {2}.\n{3}\n", nCount, sContainerType, sContentType, ex.Message);
				Trace.Write(szMsg);
				txtStatus.AppendText(szMsg);
			}
		}

		private void AddItemsToQueue<T>(Queue<T> queueType, int nCount)
		{
			Random rand = new Random(DateTime.Now.Millisecond);

			Type typeItem = typeof(T);

			Object objItem;
			for (int nIx = 0; nIx < nCount; nIx++)
			{
				objItem = (typeItem == typeof(Int32))
					? (Object)(nIx + 1)
					: (Object)(String.Format("String {0}: {1}", nIx + 1, rand.Next(1, Int32.MaxValue)));

				String szMsg = String.Format("Added {0} {1} to queue\n", typeItem.Name, objItem.ToString());
				txtStatus.AppendText(szMsg);

				queueType.Enqueue((T)objItem);
			}
		}

		private void AddItemsToStack<T>(Stack<T> stackType, int nCount)
		{
			Random rand = new Random(DateTime.Now.Millisecond);

			Type tyType = typeof(T);

			Object objItem;
			for (int nIx = 0; nIx < nCount; nIx++)
			{
				objItem = (tyType == typeof(Int32))
					? (Object)(nIx + 1)
					: (Object)(String.Format("String {0}: {1}", nIx + 1, rand.Next(1, Int32.MaxValue)));

				String szMsg = String.Format("Added {0} {1} to stack\n", tyType.Name, objItem.ToString());
				txtStatus.AppendText(szMsg);

				stackType.Push((T)objItem);
			}
		}

		private void AddItemsToSortedList<T>(SortedList<T, String> sortedList, int nCount)
		{
			Random rand = new Random(DateTime.Now.Millisecond);

			Type tyType = typeof(T);

			Object objItem;
			for (int nIx = 0; nIx < nCount; nIx++)
			{
				objItem = (tyType == typeof(Int32))
					? (Object)(nIx + 1)
					: (Object)(String.Format("Item {0}", nIx + 1));

				String szMsg = String.Format("Added {0} {1} to stack\n", tyType.Name, objItem.ToString());
				txtStatus.AppendText(szMsg);

				sortedList.Add((T)objItem, (String.Format("String {0}: {1}", nIx + 1, rand.Next(1, Int32.MaxValue))));
			}
		}

		private void RemoveItemsFromQueue<T>(Queue<T> queueType, int nCount)
		{
			Type tyItem = typeof(T);

			for (int nIx = 0; nIx < nCount; nIx++)
			{
				T item = queueType.Dequeue();

				String sMsg = String.Format("Removed {0} from queue; Value: {1}\n", tyItem.Name, item.ToString());
				txtStatus.AppendText(sMsg);
			}
		}

		private void RemoveItemsFromStack<T>(Stack<T> stackType, int nCount)
		{
			for (int nIx = 0; nIx < nCount; nIx++)
			{
				T item = stackType.Pop();

				Type typeItem = item.GetType();
				String sMsg = String.Format("Removed {0} from stack; Value = {1}\n", typeItem.Name, item.ToString());

				Trace.Write(sMsg);
				txtStatus.AppendText(sMsg);
			}
		}

		private void RemoveItemsFromSortedList<T>(SortedList<T, String> sListType, int nCount)
		{
			T[] aKeys = sListType.Keys.ToArray<T>();
			Type titemType = typeof(T);

			for (int nIx = 0; nIx < nCount; nIx++)
			{
				T tKey = aKeys[nIx];
				String sValue = sListType[tKey];
				String sMsg = String.Format("Removing SortedList Item: {0} Key='{1}'; Value='{2}'\n", titemType.Name, tKey, sValue);

				Trace.Write(sMsg);
				txtStatus.AppendText(sMsg);

				sListType.Remove(tKey);
			}
		}
	}
}
