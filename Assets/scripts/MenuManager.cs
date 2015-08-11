using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	public Menu CurrentMenu;

	public void Start() {
		ShowMenu(CurrentMenu);
	}

	public void ShowMenu (Menu menu) {
		if (CurrentMenu != null)
			CurrentMenu.IsOpen = false;

		CurrentMenu = menu;
		CurrentMenu.IsOpen = true;	
	}

	public void NewGame () {
		// Should have separate panel for this
		// that handles player creation, save creation and transition
		// to game
		Application.LoadLevel(1);
	}

	public void ExitGame () {
		Application.Quit();
	}


}
