package com.teste;

import java.util.ArrayList;
import java.util.List;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;


@RestController
@RequestMapping("/clientes")

public class Clientecontroler {

	@SuppressWarnings("null")
	@GetMapping
	public  List<String> Hello() {
		
		List<String> aaa = new ArrayList<String>();	
		
		aaa.add("It´s Working...");
		aaa.add("It´s Working...");
		aaa.add("It´s Working...");
		aaa.add("It´s Working...");
		aaa.add("It´s Working...");
		
		return aaa;
	}
	
}




