import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-listproduct',
  templateUrl: './listproduct.component.html',
  styleUrls: ['./listproduct.component.css']
})
export class ListproductComponent implements OnInit {

  constructor(private service:SharedService,private formBuilder:FormBuilder) { 
    this.checkoutForm = this.formBuilder.group({
      nombre: '',
      apellido1: '',
      apellido2: '',
      cedula: '',
      provincia: '',
      canton: '',
      distrito: '',
      tel1: '',
      tel2: '',
      rol: '',
      usuario: '',
      pass: ''
    });
  }

  //Variables
  EmpleadoList : any = []; 
  checkoutForm: any;

  ngOnInit(): void {
  }

  // agregar metodo para rellenar la tabla

}