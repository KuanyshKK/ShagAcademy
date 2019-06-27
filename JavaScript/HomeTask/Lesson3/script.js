class TV {
    constructor(brand,chanel,volume){
        //console.log("this",this);
        this.brand = brand;
        this.chanel = 1;
        this.volume = 50;
    }

    get describeTV(){
        return `${this.brand} at chanel ${this.chanel}, volume ${this.volume}`;
    }

    set brandSetter(brand){
        this.brand = brand;
    }

    set chanelSetter(chanel){
        this.chanel = chanel;
    }

    set volumeSetter(volume){
        if(volume<0){
            console.log('Volume must be higher 0');
        }
        if(volume>100){
            console.log('Volume must be lower 100');
        }
        this.volume = volume;
    }
    
    changeVolume(vol){
        if(vol<0){
            console.log('Volume must be higher 0');
            return this.volume = this.volume;
        }
        if(vol>100){
            console.log('Volume must be lower 100');
            return this.volume = this.volume;
        }
        return this.volume = vol;
    };

    changeChanel(ch){
        if(ch>50){
            console.log('Chanel must be lower 50');
            return this.chanel = this.chanel;
        }        
        if(ch<0){
            console.log('Chanel must be higher 0');
            return this.chanel = this.chanel;
        }
        return this.chanel = ch;
    }

    resetTV(){
        this.volume = 50;
        this.chanel = 1;
    }
    
}

var samsung = new TV('samsung');
samsung.changeVolume(18);
console.log(samsung.describeTV);
samsung.changeChanel(45);
console.log(samsung.describeTV);
samsung.resetTV();
console.log(samsung.describeTV);