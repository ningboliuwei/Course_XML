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

			Random random = new Random(Guid.NewGuid().GetHashCode());

			number = random.Next(1, 100);
			return number;
		}

		public string GenerateOperatorString() //产生随机的运算符
		{
			int number = 0;
			string[] operatorString = new string[] { "+", "-", "*", "/" };

			Random random = new Random(Guid.NewGuid().GetHashCode());
			number = random.Next(0, 3);

			return operatorString[number];
		}

		[WebMethod]
		public Answer GetAnswer(Question question, int userAnswer)
		{
			int rightAnswer = 0;
			string answerStatusString;

			string questionString;

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

			questionString = question.Operand1 + " " + question.OperatorString + " " + question.Operand2;

			if (userAnswer == rightAnswer)
			{
				answerStatusString = "√";
			}
			else
			{
				answerStatusString = "×";
			}

			Answer answer = new Answer();
			answer.QuestionString = questionString;
			answer.RightResult = rightAnswer;
			answer.UserAnswer = userAnswer;
			answer.Status = answerStatusString;

			return answer;

		}



		[WebMethod]
		[XmlInclude(typeof(Question))]
		public Question GetQuestion()
		{
			Question question = new Question();
			question.Operand1 = this.GenerateOperand();//随机生成操作数1
			question.Operand2 = this.GenerateOperand();//随机生成操作数2
			question.OperatorString = this.GenerateOperatorString();//随机生成运算符

			return question;
		}
	}
}
