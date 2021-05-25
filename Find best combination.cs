// Design (Window Form)
partial class Form1
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.txtInput = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.btnProcess = new System.Windows.Forms.Button();
        this.txtOutput = new System.Windows.Forms.RichTextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.txtTarget = new System.Windows.Forms.TextBox();
        this.chkBestOne = new System.Windows.Forms.CheckBox();
        this.chkByCount = new System.Windows.Forms.CheckBox();
        this.chkByLayer = new System.Windows.Forms.CheckBox();
        this.label3 = new System.Windows.Forms.Label();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.btnGenerateRandom = new System.Windows.Forms.Button();
        this.txtRandomRange = new System.Windows.Forms.TextBox();
        this.txtRandomMaxValue = new System.Windows.Forms.TextBox();
        this.chkJustTarget = new System.Windows.Forms.CheckBox();
        this.label4 = new System.Windows.Forms.Label();
        this.chkDuplicate = new System.Windows.Forms.CheckBox();
        this.groupBox1.SuspendLayout();
        this.SuspendLayout();
        // 
        // txtInput
        // 
        this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
        this.txtInput.Font = new System.Drawing.Font("Courier New", 9F);
        this.txtInput.Location = new System.Drawing.Point(59, 12);
        this.txtInput.Name = "txtInput";
        this.txtInput.Size = new System.Drawing.Size(291, 21);
        this.txtInput.TabIndex = 0;
        this.txtInput.Text = "3, 5, 7, 6, 6";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 15);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(34, 13);
        this.label1.TabIndex = 1;
        this.label1.Text = "Input:";
        // 
        // btnProcess
        // 
        this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
        this.btnProcess.Location = new System.Drawing.Point(504, 12);
        this.btnProcess.Name = "btnProcess";
        this.btnProcess.Size = new System.Drawing.Size(75, 20);
        this.btnProcess.TabIndex = 2;
        this.btnProcess.Text = "Process";
        this.btnProcess.UseVisualStyleBackColor = true;
        this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
        // 
        // txtOutput
        // 
        this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
        this.txtOutput.Font = new System.Drawing.Font("Courier New", 9F);
        this.txtOutput.Location = new System.Drawing.Point(15, 109);
        this.txtOutput.Name = "txtOutput";
        this.txtOutput.Size = new System.Drawing.Size(564, 616);
        this.txtOutput.TabIndex = 3;
        this.txtOutput.Text = "";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(12, 41);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(41, 13);
        this.label2.TabIndex = 4;
        this.label2.Text = "Target:";
        // 
        // txtTarget
        // 
        this.txtTarget.Font = new System.Drawing.Font("Courier New", 9F);
        this.txtTarget.Location = new System.Drawing.Point(59, 37);
        this.txtTarget.Name = "txtTarget";
        this.txtTarget.Size = new System.Drawing.Size(67, 21);
        this.txtTarget.TabIndex = 5;
        this.txtTarget.Text = "12";
        // 
        // chkBestOne
        // 
        this.chkBestOne.AutoSize = true;
        this.chkBestOne.Checked = true;
        this.chkBestOne.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkBestOne.Location = new System.Drawing.Point(40, 61);
        this.chkBestOne.Name = "chkBestOne";
        this.chkBestOne.Size = new System.Drawing.Size(67, 17);
        this.chkBestOne.TabIndex = 6;
        this.chkBestOne.Text = "best one";
        this.chkBestOne.UseVisualStyleBackColor = true;
        // 
        // chkByCount
        // 
        this.chkByCount.AutoSize = true;
        this.chkByCount.Checked = true;
        this.chkByCount.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkByCount.Location = new System.Drawing.Point(132, 40);
        this.chkByCount.Name = "chkByCount";
        this.chkByCount.Size = new System.Drawing.Size(96, 17);
        this.chkByCount.TabIndex = 7;
        this.chkByCount.Text = "by Items Count";
        this.chkByCount.UseVisualStyleBackColor = true;
        // 
        // chkByLayer
        // 
        this.chkByLayer.AutoSize = true;
        this.chkByLayer.Checked = true;
        this.chkByLayer.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkByLayer.Location = new System.Drawing.Point(234, 40);
        this.chkByLayer.Name = "chkByLayer";
        this.chkByLayer.Size = new System.Drawing.Size(66, 17);
        this.chkByLayer.TabIndex = 8;
        this.chkByLayer.Text = "by Layer";
        this.chkByLayer.UseVisualStyleBackColor = true;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(7, 19);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(43, 13);
        this.label3.TabIndex = 9;
        this.label3.Text = "Length:";
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.chkDuplicate);
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Controls.Add(this.btnGenerateRandom);
        this.groupBox1.Controls.Add(this.txtRandomMaxValue);
        this.groupBox1.Controls.Add(this.txtRandomRange);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Location = new System.Drawing.Point(357, 12);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(141, 91);
        this.groupBox1.TabIndex = 10;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Random";
        // 
        // btnGenerateRandom
        // 
        this.btnGenerateRandom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
        this.btnGenerateRandom.Location = new System.Drawing.Point(56, 65);
        this.btnGenerateRandom.Name = "btnGenerateRandom";
        this.btnGenerateRandom.Size = new System.Drawing.Size(79, 20);
        this.btnGenerateRandom.TabIndex = 11;
        this.btnGenerateRandom.Text = "Generate";
        this.btnGenerateRandom.UseVisualStyleBackColor = true;
        this.btnGenerateRandom.Click += new System.EventHandler(this.btnGenerateRandom_Click);
        // 
        // txtRandomRange
        // 
        this.txtRandomRange.Font = new System.Drawing.Font("Courier New", 9F);
        this.txtRandomRange.Location = new System.Drawing.Point(56, 15);
        this.txtRandomRange.Name = "txtRandomRange";
        this.txtRandomRange.Size = new System.Drawing.Size(79, 21);
        this.txtRandomRange.TabIndex = 11;
        this.txtRandomRange.Text = "10";
        // 
        // txtRandomMaxValue
        // 
        this.txtRandomMaxValue.Font = new System.Drawing.Font("Courier New", 9F);
        this.txtRandomMaxValue.Location = new System.Drawing.Point(56, 39);
        this.txtRandomMaxValue.Name = "txtRandomMaxValue";
        this.txtRandomMaxValue.Size = new System.Drawing.Size(79, 21);
        this.txtRandomMaxValue.TabIndex = 12;
        this.txtRandomMaxValue.Text = "20";
        // 
        // chkJustTarget
        // 
        this.chkJustTarget.AutoSize = true;
        this.chkJustTarget.Checked = true;
        this.chkJustTarget.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkJustTarget.Location = new System.Drawing.Point(113, 61);
        this.chkJustTarget.Name = "chkJustTarget";
        this.chkJustTarget.Size = new System.Drawing.Size(72, 17);
        this.chkJustTarget.TabIndex = 11;
        this.chkJustTarget.Text = "just target";
        this.chkJustTarget.UseVisualStyleBackColor = true;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(7, 43);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(30, 13);
        this.label4.TabIndex = 13;
        this.label4.Text = "Max:";
        // 
        // chkDuplicate
        // 
        this.chkDuplicate.AutoSize = true;
        this.chkDuplicate.Checked = true;
        this.chkDuplicate.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkDuplicate.Location = new System.Drawing.Point(10, 66);
        this.chkDuplicate.Name = "chkDuplicate";
        this.chkDuplicate.Size = new System.Drawing.Size(46, 17);
        this.chkDuplicate.TabIndex = 14;
        this.chkDuplicate.Text = "dupl";
        this.chkDuplicate.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(589, 737);
        this.Controls.Add(this.chkJustTarget);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.chkByLayer);
        this.Controls.Add(this.chkByCount);
        this.Controls.Add(this.chkBestOne);
        this.Controls.Add(this.txtTarget);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.txtOutput);
        this.Controls.Add(this.btnProcess);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.txtInput);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Form1";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnProcess;
    private System.Windows.Forms.RichTextBox txtOutput;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtTarget;
    private System.Windows.Forms.CheckBox chkBestOne;
    private System.Windows.Forms.CheckBox chkByCount;
    private System.Windows.Forms.CheckBox chkByLayer;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnGenerateRandom;
    private System.Windows.Forms.TextBox txtRandomRange;
    private System.Windows.Forms.TextBox txtRandomMaxValue;
    private System.Windows.Forms.CheckBox chkJustTarget;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckBox chkDuplicate;
}

// Code behind
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    List<int> inputArr = new List<int>();
    List<KeyValuePair<int, List<int>>> results = new List<KeyValuePair<int, List<int>>>();

    int destValue = 12;
    bool isBest = false;

    private void btnProcess_Click(object sender, EventArgs e)
    {
        txtOutput.Clear();
        var text = txtInput.Text.Trim();
        try
        {
            var items = text.Split(',').ToList().Select(s => int.Parse(s.Trim()));
            if (!items.Any()) {
                txtOutput.Text += "\nNo input element: ex. format a, b, c";
                return;
            }

            destValue = int.Parse(txtTarget.Text.Trim());
            isBest = chkBestOne.Checked;

            //items array: [6, 5, 11, 6, 4]
            inputArr.Clear();
            inputArr.AddRange(items.OrderByDescending(item => item));
            //inputArr array sorted: [11, 6, 6, 5, 4]

            results.Clear();

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Restart();
                txtOutput.Text += $"\nSorted in {stopWatch.ElapsedMilliseconds}ms:\n\t[{string.Join(", ", items)}]\n\t=>\n\t[{string.Join(", ", inputArr)}]\n";
                stopWatch.Restart();
                results.Clear();

                PromotionProcessingV3(inputArr);
                txtOutput.Text += $"\n============================\nProcessing in {stopWatch.ElapsedMilliseconds}ms";

                stopWatch.Start();
                PromotionPredictable();
                txtOutput.Text += $"\n============================\nPrint result in {stopWatch.ElapsedMilliseconds}ms";
            }
            catch(Exception ex)
            {
                txtOutput.Text += $"\nProcessing error: {ex.Message}";
            }
        }
        catch (Exception ex)
        {
            txtOutput.Text += "\nInput error: ex. format a, b, c";
        }
    }

    private void PrintArr(List<int> output, int result, bool test = false)
    {
        if (!output.Any()) return;

        txtOutput.Text += "Print" + (test ? "----:" : ":");
        for (int i = 0; i < output.Count; i++)
        {
            if (i != 0)
                txtOutput.Text += ", ";
            else
                txtOutput.Text += "[";
            txtOutput.Text += output[i];
            if (i == output.Count - 1)
                txtOutput.Text += "] = " + result;
        }
    }

    private void PrintArrLn(List<int> output, int result, bool test = false)
    {
        if (!output.Any()) return;

        txtOutput.Text += "\nPrint" + (test ? "----:" : ":");
        for (int i = 0; i < output.Count; i++)
        {
            if (i != 0)
                txtOutput.Text += ", ";
            else
                txtOutput.Text += "[";
            txtOutput.Text += output[i];
            if (i == output.Count - 1)
                txtOutput.Text += "] = " + result;
        }
    }

    private void PromotionPredictable()
    {
        var maxValue = results.OrderByDescending(o => o.Key).FirstOrDefault().Key;
        var destTimes = maxValue / destValue;

        txtOutput.Text += $"\n============================\nPrint min result for: { destValue }";

        int minRange = destValue - int.Parse(txtTarget.Text);
        int maxRange = destValue + int.Parse(txtTarget.Text);
        var list = results.Distinct(new ValueComparer()).Where(itm => itm.Key >= minRange && itm.Key < maxRange).ToList();
        if (chkByCount.Checked)
        {
            list = list.OrderBy(o => o.Key).ThenBy(o => o.Value.Count).ThenBy(o => o.Value.Max()).ToList();
        }
        else
        {
            list = list.OrderBy(o => o.Key).ThenBy(o => o.Value.Max()).ToList();
        }
        if (chkBestOne.Checked)
        {
            int bestRange = list.FirstOrDefault().Key;
            list = list.Where(itm => itm.Key == bestRange).ToList();
        }

        foreach (var item in list)
        {
            PrintArrLn(item.Value, item.Key, false);
        }
    }

    private void btnGenerateRandom_Click(object sender, EventArgs e)
    {
        var rdRange = int.Parse(txtRandomRange.Text.Trim());
        var rdMax = int.Parse(txtRandomMaxValue.Text.Trim()) + 1;
        Random rd = new Random();

        if (!chkDuplicate.Checked && rdMax <= rdRange)
        {
            txtOutput.Text += "Random not duplicate is can't be max value less than range";
            return;
        }

        List<int> listNumbers = new List<int>();
        for (int i = 0; i < rdRange; i++)
        {
            int number = 0;
            if (!chkDuplicate.Checked)
            {
                do
                {
                    number = rd.Next(1, rdMax);
                } while (listNumbers.Contains(number));
            }
            else
            {
                number = rd.Next(1, rdMax);
            }
            listNumbers.Add(number);
        }

        txtInput.Text = string.Join(", ", listNumbers);
    }

    #region Ver 3
    /// <summary>
    /// 
    /// </summary>
    /// <param name="rootList">sorted list</param>
    private void PromotionProcessingV3(List<int> rootList)
    {
        var fullWeight = rootList.Sum();

        // Update destValue
        if (!chkJustTarget.Checked)
        {
            var maxValue = rootList.Sum();
            var destTimes = maxValue / destValue;

            int minRange = destTimes * destValue;
            int maxRange = (destTimes + 1) * destValue;

            destValue = minRange;
            txtOutput.Text += $"\nFull weight: {fullWeight}\nMax value can be: {minRange}\nSet new range in {minRange} and {maxRange}";
        }

        // Get applicable branches
        var startableRoot = new List<int>();
        if(fullWeight - destValue <= 0)
        {
            results.Add(new KeyValuePair<int, List<int>>(fullWeight, rootList));
            return;
        }

        startableRoot.Add(rootList[0]);
        for (int pos = 1; pos < rootList.Count; pos++)
        {
            if (fullWeight - rootList[pos] == destValue)
            {
                var newList = new List<int>();
                newList.AddRange(rootList);
                newList.RemoveAt(0);
                results.Add(new KeyValuePair<int, List<int>>(fullWeight - rootList[pos], newList));
                continue;
            }
            /*
            if (fullWeight - destValue <= rootList[pos])
            {
                startableRoot.Add(pos);
                continue;
            }
            */
            if (fullWeight - rootList[pos] > destValue)
            {
                startableRoot.Add(pos);
                continue;
            }

            break;
        }

        // get combinations from startable root
        // best start root is last item
        for (int pos = startableRoot.Count - 1; pos >= 0; pos--)
        {
            var newList = new List<int>();
            newList.AddRange(rootList);

            txtOutput.Text += $"\nStart from root: idx:{pos}, value:{rootList[pos]}";
            FindBranch(newList, new List<int>(), pos);
        }
    }

    private void FindBranch(List<int> baseList, List<int> rootList, int startAt = 0)
    {
        var smallestNeed = new List<Tuple<int, int>>();
        int sumValue = rootList.Sum();
        for (int pos = startAt; pos < baseList.Count; pos++)//root layer
        {
            int currentValue = baseList[pos];
            int need = destValue - (sumValue + currentValue);

            var currentBranch = new List<int>();
            currentBranch.AddRange(rootList);

            if (need <= 0)
            {
                currentBranch.Add(currentValue);
                results.Add(new KeyValuePair<int, List<int>>(sumValue + currentValue, currentBranch));
                startAt = pos;
                continue;
            }

            smallestNeed.Add(new Tuple<int, int>(baseList[pos], destValue - (sumValue + baseList[pos])));
        }
        if (smallestNeed.Count > 0)
        {
            rootList.Add(smallestNeed.OrderBy(o => o.Item2).FirstOrDefault().Item1);
            FindBranch(baseList, rootList, startAt + 1);
        }
    }
    #endregion
}
public class ValueComparer : IEqualityComparer<KeyValuePair<int, List<int>>>
{
    public bool Equals(KeyValuePair<int, List<int>> x, KeyValuePair<int, List<int>> y)
    {
        return GetHashCode(x).Equals(GetHashCode(y));
    }

    public int GetHashCode(KeyValuePair<int, List<int>> obj)
    {
        try
        {
            return int.Parse(string.Join("", obj.Value));
        }
        catch(Exception ex)
        {
            return obj.Key;
        }
    }
}
