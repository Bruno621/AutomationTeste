package Unidade_TU;

import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;
import static org.junit.Assert.fail;

import org.junit.Assert;
import org.junit.Test;

import Unidade.Util;

public class Util_Test {

	Util u = new Util();
	
	@Test 
	public void Testando_Metodo_Retorna_String() {		
	
		boolean a = u.RetornaTexto("");
	    System.out.println(a);
	    if(a == false) {fail();}
	}
	@Test 
	public void Testando_Metodo_Retorna_String2() {		
		boolean a = u.RetornaTexto("Working...");
		System.out.println(a);
		if(a == false) {fail();}
	}
	@Test 
	public void Testando_Metodo_Retorna_String3() {		
	
		boolean a = u.RetornaTexto("Working");
	    System.out.println(a);
	    if(a == false) {fail();}
	}
	@Test 
	public void Testando_Metodo_Retorna_String4() {		
		boolean a = u.RetornaTexto("Working...");
		System.out.println(a);
		if(a == false) {fail();}
	}
	
	@Test 
	public void Testando_Metodo_Soma() {		
		boolean a = u.Soma(1,1);
		System.out.println(a);
		if(a == false) {fail();}
	}
	
	@Test 
	public void Testando_Metodo_Soma2() {		
		boolean a = u.Soma(0,1);
		System.out.println(a);
		if(a == false) {fail();}
	}
	@Test 
	public void Testando_Metodo_Soma3() {		
		boolean a = u.Soma(0,1);
		System.out.println(a);
		if(a == false) {fail();}
	}
	
}
