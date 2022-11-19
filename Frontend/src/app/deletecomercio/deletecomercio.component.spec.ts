import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeletecomercioComponent } from './deletecomercio.component';

describe('DeletecomercioComponent', () => {
  let component: DeletecomercioComponent;
  let fixture: ComponentFixture<DeletecomercioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeletecomercioComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeletecomercioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
