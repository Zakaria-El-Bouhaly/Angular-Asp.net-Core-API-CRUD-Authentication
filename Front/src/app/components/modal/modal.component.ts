import { ChangeDetectionStrategy, Component, Input } from '@angular/core';
import { Subscription } from 'rxjs';
import { ModalService } from 'src/app/Services/modal.service';

@Component({
  selector: 'app-modal',
  templateUrl: './modal.component.html',
  styleUrls: ['./modal.component.scss']
})
export class ModalComponent {
  @Input() title: string = "Title";
  isModalOpen: boolean = false;
  subOpen: Subscription = new Subscription;
  subError: Subscription = new Subscription;
  subSuccess: Subscription = new Subscription;

  errorMessage: string = "";
  successMessage: string = "";



  constructor(private modalService: ModalService) { }

  ngOnInit(): void {
    this.subOpen = this.modalService.getModalOpen().subscribe((isOpen: boolean) => {
      this.isModalOpen = isOpen;
    })
    this.subError = this.modalService.getModalError().subscribe((message: string) => {
      this.errorMessage = message;
    })
    this.subSuccess = this.modalService.getModalSuccess().subscribe((message: string) => {
      this.successMessage = message;
    })
  }

  closeModal() {
    this.modalService.closeModal();
  }

  ngOnDestroy(): void {
    this.subOpen.unsubscribe();
  }

}
