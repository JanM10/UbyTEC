import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdaterepartidorComponent } from './updaterepartidor.component';

describe('UpdaterepartidorComponent', () => {
  let component: UpdaterepartidorComponent;
  let fixture: ComponentFixture<UpdaterepartidorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdaterepartidorComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UpdaterepartidorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
