#pragma once

namespace NamesCMasMas {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Names
	/// </summary>
	public ref class Names : public System::Windows::Forms::Form
	{
	public:
		Names(void)
		{
			InitializeComponent();
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Names()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::ListBox^ lstNames;
	protected:
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::TextBox^ txtName;
	private: System::Windows::Forms::Button^ btnAdd;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->lstNames = (gcnew System::Windows::Forms::ListBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->txtName = (gcnew System::Windows::Forms::TextBox());
			this->btnAdd = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// lstNames
			// 
			this->lstNames->FormattingEnabled = true;
			this->lstNames->ItemHeight = 16;
			this->lstNames->Location = System::Drawing::Point(12, 27);
			this->lstNames->Name = L"lstNames";
			this->lstNames->Size = System::Drawing::Size(120, 94);
			this->lstNames->TabIndex = 0;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(12, 9);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(45, 15);
			this->label1->TabIndex = 1;
			this->label1->Text = L"Names";
			// 
			// txtName
			// 
			this->txtName->Location = System::Drawing::Point(138, 26);
			this->txtName->Name = L"txtName";
			this->txtName->Size = System::Drawing::Size(100, 23);
			this->txtName->TabIndex = 2;
			// 
			// btnAdd
			// 
			this->btnAdd->Location = System::Drawing::Point(138, 55);
			this->btnAdd->Name = L"btnAdd";
			this->btnAdd->Size = System::Drawing::Size(100, 23);
			this->btnAdd->TabIndex = 3;
			this->btnAdd->Text = L"Add Name";
			this->btnAdd->UseVisualStyleBackColor = true;
			this->btnAdd->Click += gcnew System::EventHandler(this, &Names::btnAdd_Click);
			// 
			// Names
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(7, 15);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(268, 180);
			this->Controls->Add(this->btnAdd);
			this->Controls->Add(this->txtName);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->lstNames);
			this->Name = L"Names";
			this->Text = L"Names";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	
	private: System::Void btnAdd_Click(System::Object^ sender, System::EventArgs^ e) {
		String^ name = txtName->Text;
			if (!String::IsNullOrWhiteSpace(name) && !lstNames->Items->Contains(name))
			{
				lstNames->Items->Add(name);
			}
		}
	};
}
