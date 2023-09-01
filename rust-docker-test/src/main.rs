use abomonation::{decode, encode};

fn main() {
    let mut bytes = Vec::new();
    unsafe { encode(&"Hello World".to_owned(), &mut bytes).unwrap(); }
    if let Some((result, remaining)) = unsafe { decode::<String>(&mut bytes) } {
        println!("{}, remaining: {:?}", result, remaining);
    } else {
        println!("Decoding failed");
    }
}
