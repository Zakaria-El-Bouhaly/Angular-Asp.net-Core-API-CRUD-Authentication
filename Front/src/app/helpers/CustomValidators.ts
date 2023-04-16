import { AbstractControl, ValidatorFn } from '@angular/forms';

export function confirmPasswordValidator(controlName: string, matchingControlName: string): ValidatorFn {
    return (control: AbstractControl): { [key: string]: any } | null => {
        const controlValue = control.get(controlName)?.value;
        const matchingControlValue = control.get(matchingControlName)?.value;

        if (controlValue !== matchingControlValue) {
            return { passwordsNotMatch: true };
        }

        return null;
    };
}
