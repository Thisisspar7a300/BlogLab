export class Photo {
    
    constructor(
        public photoId: number,
        public applicationUserId: number,
        public imageUrl: number,
        public publicId: string,
        public description: string,
        public publishDate: Date,
        public updatDate: Date,
        public deleteConfirm: boolean = false
      
    ){}
}