import { DatePipe } from "@angular/common";
import { Pipe, PipeTransform } from "@angular/core";

@Pipe({ name: 'dateFormat' })
export class DateFormatPipe implements PipeTransform {
    transform(value: any): any {
        // check if value is a valid date        

        if (isNaN(Date.parse(value)) || value.toString().length < 8) {
            return value;
        }
        // use DatePipe to format the date
        const datePipe = new DatePipe('en-US');
        return datePipe.transform(value, 'medium');
    }
}
