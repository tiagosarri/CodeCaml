using NecroNet.SharePoint.CodeCaml.ConstraintInterfaces;
using NecroNet.SharePoint.CodeCaml.Elements.Base;
using NecroNet.SharePoint.CodeCaml.Enums;

namespace NecroNet.SharePoint.CodeCaml.Elements
{
	public class CQAndElement : CQElement
	{
		public CQAndElement(ICQElement left, ICQElement right)
		{
			_elements.Add(left);
			_elements.Add(right);
		}

		protected override CQTag Tag
		{
			get { return CQTag.And; }
		}
	}
}