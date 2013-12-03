using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService的使用_实验_四则运算
{
	public partial class CaculationTest : System.Web.UI.Page
	{
		private static List<CaculationService.Answer> answerHistory;

		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnGenerate_Click(object sender, EventArgs e)
		{
			CaculationService.Caculation caculationService = new CaculationService.Caculation();
			CaculationService.Question question = caculationService.GetQuestion();
			txtNumber1.Text = question.Operand1.ToString();
			lblOperator.Text = question.OperatorString;
			txtNumber2.Text = question.Operand2.ToString();
		}

		protected void btnJudge_Click(object sender, EventArgs e)
		{
			int userAnswer = Convert.ToInt32(txtResult.Text);

			CaculationService.Question question = new CaculationService.Question();
			question.Operand1 = Convert.ToInt32(txtNumber1.Text);
			question.Operand2 = Convert.ToInt32(txtNumber2.Text);
			question.OperatorString = lblOperator.Text;

			CaculationService.Caculation caculationService = new CaculationService.Caculation();
			CaculationService.Answer answer = caculationService.GetAnswer(question, userAnswer);

			if (answerHistory == null)
			{
				answerHistory = new List<CaculationService.Answer>();
			}

			answerHistory.Add(answer);
			gdvQuestions.DataSource = answerHistory;
			gdvQuestions.DataBind();

			this.Reset();
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