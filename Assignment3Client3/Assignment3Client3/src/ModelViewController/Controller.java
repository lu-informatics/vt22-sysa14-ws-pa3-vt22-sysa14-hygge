package ModelViewController;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Controller {
	private HyggeFrame hyggeFrame;
	
	public Controller(HyggeFrame hyggeFrame) {
		this.hyggeFrame = hyggeFrame;	
		declareListerns();
		
	}
	public void declareListerns () {
		hyggeFrame.getBtnSearch().addActionListener(new ActionListener() {  //	hyggeFrame.getBtnSearch().add h�mtar en referens till knappen, knappen ligger p� heepen som ett obejkt
			public void actionPerformed(ActionEvent e) {
				System.out.println("Hej");
			}
		});
	}

}
