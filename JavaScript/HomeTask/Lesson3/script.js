class TV {
    constructor(brand,chanel,volume){
        console.log("this",this);

        this.brand = brand;
        this.chanel = chanel;
        this.volume = volume;
    }

    get describeTV(){
        return `${this.brand} ${this.chanel} ${this.volume}`;
    }

    set brandSetter(brand){
        this.brand = brand;
    }

    set chanelSetter(chanel){
        this.chanel = chanel;
    }

    set volumeSetter(volume){
        this.volume = volume;
    }
    
}