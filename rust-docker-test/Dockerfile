# Build the rust binary
FROM rust:latest as builder

WORKDIR /app

# Copy the source
COPY . /app

# Build
RUN cargo install cargo-auditable cargo-audit
RUN cargo auditable build --release

# Use distroless as minimal base image to package the manager binary
# Refer to https://github.com/GoogleContainerTools/distroless for more details
FROM gcr.io/distroless/cc:nonroot

WORKDIR /
COPY --from=builder /app/target/release/rust-docker-test /

ENTRYPOINT ["/rust-docker-test"]
