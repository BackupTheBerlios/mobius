using System;

namespace Mobius
{
	
	public class ExpandedTreeNode : System.Windows.Forms.TreeNode
	{

		private object mAssociatedObject;

		public ExpandedTreeNode() : base()
		{
			this.mAssociatedObject = null;
		}

		public ExpandedTreeNode(string text) : base(text)
		{
			this.mAssociatedObject = null;
		}

		public object AssociatedObject
		{
			get { return this.mAssociatedObject; }
			set { this.mAssociatedObject = value; }
		}
	}
}
