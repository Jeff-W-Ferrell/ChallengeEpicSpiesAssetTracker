using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class SpyAssetTracker : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assetNames = new string[0];
                ViewState.Add("assets", assetNames);               

                int[] electionsRigged = new int[0];
                ViewState.Add("elections", electionsRigged);                

                double[] actsOfSubterfuge = new double[0];
                ViewState.Add("subterfuge", actsOfSubterfuge);                
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string[] assetNames = (string[])ViewState["assets"];
            Array.Resize(ref assetNames, assetNames.Length + 1);
            int newAsset = assetNames.GetUpperBound(0);
            assetNames[newAsset] = assetNameTextBox.Text;
            string latestAsset = assetNames[newAsset];
            ViewState["assets"] = assetNames;
            assetNameTextBox.Text = "";

            int[] electionsRigged = (int[])ViewState["elections"];
            Array.Resize(ref electionsRigged, electionsRigged.Length + 1);
            int newElectionsRigged = electionsRigged.GetUpperBound(0);
            electionsRigged[newElectionsRigged] = int.Parse(electionsRiggedTextBox.Text);
            ViewState["elections"] = electionsRigged;
            electionsRiggedTextBox.Text = "";

            double[] actsOfSubterfuge = (double[])ViewState["subterfuge"];
            Array.Resize(ref actsOfSubterfuge, actsOfSubterfuge.Length + 1);
            int newActsOfSubterfuge = actsOfSubterfuge.GetUpperBound(0);
            actsOfSubterfuge[newActsOfSubterfuge] = double.Parse(actsOfSubterfugeTextBox.Text);
            ViewState["subterfuge"] = actsOfSubterfuge;
            actsOfSubterfugeTextBox.Text = "";

            performanceLabel.Text = String.Format
                ("Total Elections Rigged: {0} <br/> Average Acts of Subterfuge per Asset: {1:N2} <br/> (Last Asset you Added: {2})",
                electionsRigged.Sum(),
                actsOfSubterfuge.Average(),
                latestAsset);

        }
    }
}