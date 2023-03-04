package com.teste;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class ApiTesteApplication {

	public static void main(String[] args) {

	    System.setProperty("server.port", "8001");
		SpringApplication.run(ApiTesteApplication.class, args);
	}

}
