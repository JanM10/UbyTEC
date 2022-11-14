import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-tabla-empl',
  templateUrl: './tabla-empl.component.html',
  styleUrls: ['./tabla-empl.component.css']
})
export class TablaEmplComponent implements OnInit {

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
