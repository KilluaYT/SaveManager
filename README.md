# SaveManager
Simple SaveManager

##DOCUMENTATION
---------------------------------------------------------------------------
Adding to Project example:

using SaveManager;
SaveManager.SaveManager saveManager = new SaveManager.SaveManager();
---------------------------------------------------------------------------
Saving Data example:

saveManager.AddKey("somebool", false);
saveManager.AddKey("someInt", 1234);
saveManager.Save_Data("C:\\SomeFolder\\save.txt");
---------------------------------------------------------------------------
Reading Data example:

saveManager.Read_Data("C:\\SomeFolder\\save.txt");
int i = saveManager.GetKey_int("someInt");
textBox1.Text = "someInt=" + i;
---------------------------------------------------------------------------
Others:

saveManager.Clear_Data();  // useful to clear if you had added key's for other save.
saveManager.Delete_Data("C:\\SomeFolder\\save.txt"); // will delete the save file
