namespace WebService的使用_实验_四则运算
{
	public class Answer
	{
		public string QuestionString { get; set; } //问题字符串

		public int RightResult { get; set; } //正确答案

		public int UserAnswer { get; set; } //用户答案

		public string Status { get; set; } //答题状态（√/×）
	}
}