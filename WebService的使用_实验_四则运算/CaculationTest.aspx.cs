#region

using System;
using System.Collections.Generic;
using System.Web.UI;

#endregion

namespace WebService的使用_实验_四则运算
{
	public partial class CaculationTest : Page
	{
		private static List<CaculationService.Answer> answerHistory;

		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnGenerate_Click(object sender, EventArgs e)
		{
			//创建一个Web引用类型的对象
			CaculationService.Caculation caculationService = new CaculationService.Caculation(); 
			CaculationService.Question question = caculationService.GetQuestion();
			//调用Web Service的GetQuestion()方法，得到一个Question类型的对象
			//将question对象的操作数1属性显示在相应文本框中
			txtNumber1.Text = question.Operand1.ToString();
			//将question对象的运算符字符串属性显示在相应标签中
			lblOperator.Text = question.OperatorString;
			//将question对象的操作数2属性显示在相应文本框中
			txtNumber2.Text = question.Operand2.ToString();
		}

		protected void btnJudge_Click(object sender, EventArgs e)
		{
			//得到用户输入的答案
			int userAnswer = Convert.ToInt32(txtResult.Text);
			//创建一个Question类型的对象（用于作为参数传递给GetAnswer()方法）
			CaculationService.Question question = new CaculationService.Question();
			//将“操作数1”文本框中的数值作为question对象的“操作数1”属性
			question.Operand1 = Convert.ToInt32(txtNumber1.Text);
			//将“操作数2”文本框中的数值作为question对象的“操作数2”属性
			question.Operand2 = Convert.ToInt32(txtNumber2.Text);
			//将运算符字符串标签中的数值作为question对象的“运算符字符串”属性
			question.OperatorString = lblOperator.Text;
			//创建一个Web引用类型的对象
			CaculationService.Caculation caculationService = new CaculationService.Caculation();
			//调用Web Service的GetAnswer()方法，得到一个Answer类型的对象
			CaculationService.Answer answer = caculationService.GetAnswer(question, userAnswer);

			//判断answerHistory泛型是否为空
			if (answerHistory == null)
			{
				//若为空（表示没有任何数据），则创建对象
				answerHistory = new List<CaculationService.Answer>(); 
			}
			//将answer对象添加到泛型中
			answerHistory.Add(answer);
			//将泛型作为GridView的DataSource
			gdvQuestions.DataSource = answerHistory;
			//调用GridView的DataBind()方法，显示数据
			gdvQuestions.DataBind();

			Reset(); //清空页面
		}

		private void Reset()
		{
			txtNumber1.Text = "";
			txtNumber2.Text = "";
			txtResult.Text = "";
			lblOperator.Text = "";
		}
	}
}