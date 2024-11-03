import { Photo } from "./photo"

export interface Member {
    id: number
    username: string
    age: number
    photoUrl: string
    created: Date
    lastActive: Date
    knownAs: string
    introduction: string
    interests: string
    gender: string
    lookingFor: string
    city: string
    country: string
    photos: Photo[]
  }
  

  