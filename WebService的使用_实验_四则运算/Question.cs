namespace WebService的使用_实验_四则运算
{
	using System;

	[Serializable]
	public class Question
	{
		#region Public Properties

		public int Operand1 { get; set; } //操作数1

		public int Operand2 { get; set; } //操作数2

		public string OperatorString { get; set; }

		#endregion

		//操作字符串
	}
}