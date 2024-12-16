export class PagedResults<T> {
    constructor(
        public items:Array<T>,
        public totalCount:number
    ){}
}