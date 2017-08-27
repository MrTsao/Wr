using System;
namespace SySoft
{
    public interface IIdGenerator
	{
		string IDGroup
		{
			get;
			set;
		}
		string IDPrefix
		{
			get;
			set;
		}
		string NewID();
	}

	public class CMemIdGenerator : IIdGenerator
	{
		private static long m_NewIDCount = (long)DateTime.Now.Millisecond * 100L;
		private string m_IDGroup = "";
		private string m_IDPrefix = "";
		public string IDPrefix
		{
			get
			{
				return this.m_IDPrefix;
			}
			set
			{
				this.m_IDPrefix = value;
			}
		}
		public string IDGroup
		{
			get
			{
				return this.m_IDGroup;
			}
			set
			{
				this.m_IDGroup = value;
			}
		}
		public CMemIdGenerator()
		{
			this.IDPrefix = string.Empty;
		}
		private string FormatString36(long val, int len)
		{
			long num = val;
			string text = "";
			while (num > 0L)
			{
				long num2 = num % 36L;
				text = ((num2 < 10L) ? num2.ToString() : ((char)(num2 - 10L + 65L)).ToString()) + text;
				num /= 36L;
			}
			text = text.PadLeft(len, '0');
			return text.Substring(text.Length - len);
		}
		public string NewID()
		{
			return this.IDPrefix + this.IDGroup + this.GetMaxID();
		}
		protected virtual string GetMaxID()
		{
			string result;
			lock (typeof(CMemIdGenerator))
			{
				DateTime now = DateTime.Now;
				string text = string.Concat(new string[]
				{
					this.FormatString36((long)(now.Year % 1000), 2),
					now.Month.ToString("X"),
					this.FormatString36((long)now.Day, 1),
					this.FormatString36((long)((now.Hour * 3600 + now.Minute * 60 + now.Second) * 1000 + now.Millisecond), 6),
					this.FormatString36(CMemIdGenerator.m_NewIDCount % 10000L, 3)
				});
				CMemIdGenerator.m_NewIDCount += 1L;
				result = text;
			}
			return result;
		}
	}
}
