using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService的使用_实验_四则运算
{
	using System.Xml.Serialization;

	/// <summary>
	/// Caculation 的摘要说明
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
	// [System.Web.Script.Services.ScriptService]
	public class Caculation : System.Web.Services.WebService
	{
		//产生1~100之间的随机整数
		public int GenerateOperand()
		{
			int number = 0;

			//创建一个Random对象，用于产生随机数。构造函数参数用于保证随机种子的随机性
			Random random = new Random(Guid.NewGuid().GetHashCode());

			number = random.Next(1, 100);
			return number;
		}

		public string GenerateOperatorString() //产生随机的运算符
		{
			int number = 0;
			string[] operatorString = new string[] { "+", "-", "*", "/" };//定义一个由四个运算符字符串组成的字符串数组

			Random random = new Random(Guid.NewGuid().GetHashCode());//创建一个Random对象
			number = random.Next(0, 3);//生成一个0-3之间的整数

			return operatorString[number];//返回运算符数组中的某一个运算符
		}

		[WebMethod]
		//通过传入一个Question类型的对象，与用户的答案，来生成一条答题记录
		public Answer GetAnswer(Question question, int userAnswer)
		{
			int rightAnswer = 0;//正确答案
			string answerStatusString;//答题状态字符串

			string questionString;//问题字符串

			//根据生成的问题中的不同的运算符，计算问题的正确答案
			switch (question.OperatorString)
			{
				case "+":
					rightAnswer = question.Operand1 + question.Operand2;
					break;
				case "-":
					rightAnswer = question.Operand1 - question.Operand2;
					break;
				case "*":
					rightAnswer = question.Operand1 * question.Operand2;
					break;
				case "/":
					rightAnswer = question.Operand1 / question.Operand2;
					break;
				default:
					break;
			}

			//答题记录中的问题字符串（如 “10 + 32”）
			questionString = question.Operand1 + " " + question.OperatorString + " " + question.Operand2;

			//通过判断用户答案与正确答案是否一致，来设置答题状态为“√”还是“×”
			if (userAnswer == rightAnswer)
			{
				answerStatusString = "√";
			}
			else
			{
				answerStatusString = "×";
			}

			
			Answer answer = new Answer();//创建一个答题记录对象（Answer对象）
			answer.QuestionString = questionString;
			answer.RightResult = rightAnswer;
			answer.UserAnswer = userAnswer;
			answer.Status = answerStatusString;

			return answer;//返回answer对象

		}



		[WebMethod]
		[XmlInclude(typeof(Question))]
		public Question GetQuestion()
		{
			Question question = new Question();//创建一个Question类型的对象
			question.Operand1 = this.GenerateOperand();//随机生成操作数1
			question.Operand2 = this.GenerateOperand();//随机生成操作数2
			question.OperatorString = this.GenerateOperatorString();//随机生成运算符

			return question;//返回question对象
		}
	}
}
